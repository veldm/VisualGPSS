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
            }
            else ChanellCountCB.Enabled = false;

            LabelTextBox.Text = device.Label;

            for (int ii = 0; !(ii > schema.Elements.Count); ii++)
                numberComboBox.Items.Add((ii + 1).ToString());
            numberComboBox.SelectedIndex = numberComboBox.Items.Count - 1;
            numberComboBox.SelectedItem = device.number;

            NameTextBox.Text = device.Name;
            QueueTextBox.Text = device.QueueName;
            DelayTextBox.Text = device.Delay.ToString();
            ScatterTextBox.Text = device.Scatter.ToString();
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            //if (multiChanellCB.Checked == device.IsMultiChanell)
            //{
                //if (ChanellCountCB.Enabled)
                    //device.ChanellCount = (int)ChanellCountCB.Value;

                if (schema.Labels.TryGetValue
                       (LabelTextBox.Text, out VisualElement visualElement))
                {
                    if (schema.LabelsList.Contains(LabelTextBox.Text))
                        throw new Exception($"Метка {LabelTextBox.Text} уже занята" +
                            $" блоком №{visualElement.number} ({visualElement.Name})");
                }

                //device.number = uint.Parse(numberComboBox.Text);

                //device.Name = NameTextBox.Text;
            //}
            //else
            //{
                schema.Remove(device);
                SaveButton.Click += CreateNewDevice;
                SaveButton.Click -= SaveChanges;
                CreateNewDevice(sender, e);
            //}
        }
    }
}
