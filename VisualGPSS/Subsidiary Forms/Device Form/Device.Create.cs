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
        public Device(VisualGPSS_Schema schema, Point center, bool isMultiChanell)
        {
            InitializeComponent();
            this.schema = schema;
            this.center = center;

            multiChanellCB.Checked = isMultiChanell;

            for (int ii = 0; !(ii > schema.Elements.Count); ii++)
                numberComboBox.Items.Add((ii + 1).ToString());
            //numberComboBox.SelectedIndex = numberComboBox.Items.Count - 1;
            numberComboBox.SelectedIndex = numberComboBox.Items.IndexOf(
                (schema.GetPlace(center) + 1).ToString());

            SaveButton.Click += CreateNewDevice + onSave;
        }

        private void CreateNewDevice(object sender, EventArgs e)
        {
            uint number = uint.Parse(numberComboBox.Text);
            string label = LabelTextBox.Text;
            string name = NameTextBox.Text;
            string queue = QueueTextBox.Text;
            string delay = DelayTextBox.Text;
            string scatter = ScatterTextBox.Text;
            int? chanellCount = null, transactSize = null;
            if (ChanellCountCB.Enabled)
            {
                chanellCount = (int?)ChanellCountCB.Value;
                transactSize = (int?)transactSizeCB.Value;
            }

            if (chanellCount is null)
                schema.AddDevice(number - 1, center, schema, label, queue, name, delay, scatter);
            else schema.AddDevice(number - 1, center, schema, label, queue, name, delay, scatter,
                chanellCount.Value, transactSize.Value);

            DeleteButton.Enabled = true;
            SaveButton.Click -= CreateNewDevice;
            //SaveButton += 
            device = (GPSS.Visualiztion.Device)schema.Elements[(int)number - 1];
            propertyGrid.SelectedObject = device;
        }
    }
}
