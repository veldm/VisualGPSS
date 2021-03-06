using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSS.Visualiztion;

namespace VisualGPSS
{
    public partial class Device : MaterialSkin.Controls.MaterialForm
    {
        public Device(VisualGPSS_Schema schema, Point center)
        {
            InitializeComponent();
            this.schema = schema;
            this.center = center;

            for (int ii = 0; !(ii > schema.Elements.Count); ii++)
                numberComboBox.Items.Add((ii + 1).ToString());
            numberComboBox.SelectedIndex = numberComboBox.Items.Count - 1;

            SaveButton.Click += CreateNewDevice + onSave;
        }

        private void CreateNewDevice(object sender, EventArgs e)
        {
            uint number = uint.Parse(numberComboBox.Text);
            string label = LabelTextBox.Text;
            string name = NameTextBox.Text;
            string queue = QueueTextBox.Text;
            double delay = double.Parse(DelayTextBox.Text);
            double scatter = double.Parse(ScatterTextBox.Text);
            int? chanellCount = null;
            if (numberComboBox.Enabled) chanellCount = (int?)ChanellCountCB.Value;

            if (chanellCount is null)
                schema.AddDevice(number, center, schema, label, queue, name, delay, scatter);
            else schema.AddDevice(number, center, schema, label, queue, name, delay, scatter, chanellCount.Value);

            DeleteButton.Enabled = true;
            SaveButton.Click -= CreateNewDevice;
            //SaveButton += 
            device = (GPSS.Visualiztion.Device)schema.Elements[(int)number];
            propertyGrid.SelectedObject = device;
        }
    }
}
