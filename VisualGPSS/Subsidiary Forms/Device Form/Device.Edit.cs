using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSS.Visualiztion;

namespace VisualGPSS
{
    public partial class Device : MaterialSkin.Controls.MaterialForm
    {
        public Device(GPSS.Visualiztion.Device _device, VisualGPSS_Schema _schema)
        {
            InitializeComponent();
            device = _device;
            schema = _schema;
            SaveButton.Click += SaveChanges + onSave;

            multiChanellCB.Checked = device.IsMultiChanell;
            if (device.IsMultiChanell)
            {
                ChanellCountCB.Value = device.ChanellCount;
                ChanellCountCB.Enabled = true;
                transactSizeCB.Value = device.TransactSize;
                transactSizeCB.Enabled = true;
            }
            else ChanellCountCB.Enabled = false;

            LabelTextBox.Text = device.Label;

            for (int ii = 0; !(ii > schema.Elements.Count); ii++)
                numberComboBox.Items.Add((ii + 1).ToString());
            numberComboBox.SelectedItem = (device.number + 1).ToString();

            DelayComboBox.DataSource =
               GPSS.DataType.Math.GetDataSource(schema, out List<string> delayTag);
            DelayComboBox.Tag = delayTag;
            ScatterComboBox.DataSource =
                GPSS.DataType.Math.GetDataSource(schema, out List<string> scatterTag);
            ScatterComboBox.Tag = scatterTag;
            DelayComboBox.SelectedIndex = ScatterComboBox.SelectedIndex = -1;

            NameTextBox.Text = device.Name;
            QueueTextBox.Text = device.QueueName;
            DelayTextBox.Text = device.Delay.ToString();
            ScatterTextBox.Text = device.Scatter.ToString();

            propertyGrid.SelectedObject = device;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            //if (multiChanellCB.Checked == device.IsMultiChanell)
            //{
            //if (ChanellCountCB.Enabled)
            //device.ChanellCount = (int)ChanellCountCB.Value;

            if (LabelTextBox.Text != device.Label)
            {
                if (schema.Labels.TryGetValue
                    (LabelTextBox.Text, out VisualElement visualElement))
                {
                    throw new Exception($"Метка {LabelTextBox.Text} уже занята" +
                        $" блоком №{visualElement.number} ({visualElement.Name})");
                }
                else
                {
                    string oldLabel = device.Label;
                    device.Label = LabelTextBox.Text;
                    schema.Elements.UpdateLinks(oldLabel, device.Label);
                }
            }

            try
            {
                device.number = uint.Parse(numberComboBox.Text) - 1;
                device.Label = LabelTextBox.Text;

                string old = device.Name;
                device.Name = NameTextBox.Text;
                schema.Elements.UpdateLinks(old, device.Name);
                old = device.QueueName;
                device.QueueName = QueueTextBox.Text;
                schema.Elements.UpdateLinks(old, device.QueueName);

                device.Delay = DelayTextBox.Text;
                device.Scatter = ScatterTextBox.Text;
                if (ChanellCountCB.Enabled)
                {
                    device.ChanellCount = (int)ChanellCountCB.Value;
                    device.TransactSize = (int)transactSizeCB.Value;
                }
            }
            catch (IndexOutOfRangeException)
            {
                var index = schema.Elements.IndexOf(device);
                var newDevice = new GPSS.Visualiztion.Device(
                    uint.Parse(numberComboBox.Text) - 1, device.center, schema,
                    LabelTextBox.Text, QueueTextBox.Text, NameTextBox.Text, DelayTextBox.Text,
                    ScatterTextBox.Text, ChanellCountCB.Enabled ? (int)ChanellCountCB.Value : 1,
                    ChanellCountCB.Enabled ? (int)transactSizeCB.Value : 1);
                schema.Elements[index] = newDevice;
                foreach (var trs in schema.Transfers.Where(t => t.StartBlock == device))
                    trs.StartBlock = newDevice;
                foreach (var trs in schema.Transfers.Where(t => t.Block1 == device))
                    trs.Block1 = newDevice;
                foreach (var trs in schema.Transfers.Where(t => t.Block2 == device))
                    trs.Block2 = newDevice;
                newDevice.BlockColor = device.BlockColor;
                newDevice.MainColor = device.MainColor;
                newDevice.FontColor = device.FontColor;
                newDevice.Font = device.Font;
                newDevice.LinesColor = device.LinesColor;
                propertyGrid.SelectedObject = device = newDevice;
            }

            //device.number = uint.Parse(numberComboBox.Text);

            //device.Name = NameTextBox.Text;
            //}
            //else
            //{
            //schema.Remove(device);
            //SaveButton.Click += CreateNewDevice;
            //SaveButton.Click -= SaveChanges;
            //CreateNewDevice(sender, e);
            //}
        }
    }
}
