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
            numberComboBox.SelectedIndex = numberComboBox.Items.Count - 1;
            numberComboBox.SelectedItem = device.number;

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
                else device.Label = LabelTextBox.Text;
            }

            device.number = uint.Parse(numberComboBox.Text) - 1;
            device.Label = LabelTextBox.Text;
            device.Name = NameTextBox.Text;
            device.QueueName = QueueTextBox.Text;
            device.Delay = DelayTextBox.Text;
            device.Scatter = ScatterTextBox.Text;
            if (ChanellCountCB.Enabled)
            {
                device.ChanellCount = (int)ChanellCountCB.Value;
                device.TransactSize = (int)transactSizeCB.Value;
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
