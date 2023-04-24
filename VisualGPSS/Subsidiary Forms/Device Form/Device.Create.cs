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
        public string label;

        public Device(VisualGPSS_Schema schema, Point center,
            bool isMultiChanell = false, string label = null, int? _num = null)
        {
            InitializeComponent();
            this.schema = schema;
            this.center = center;
            if (label is not null) LabelTextBox.Text = label;

            multiChanellCB.Checked = isMultiChanell;

            for (int ii = 0; !(ii > schema.Elements.Count); ii++)
                numberComboBox.Items.Add((ii + 1).ToString());
            //numberComboBox.SelectedIndex = numberComboBox.Items.Count - 1;
            if (_num is null)
                numberComboBox.SelectedIndex = numberComboBox.Items.IndexOf(
                    (schema.GetPlace(center) + 1).ToString());
            else numberComboBox.SelectedIndex = _num.Value - 1;

            DelayComboBox.DataSource =
                GPSS.DataType.Math.GetDataSource(schema, out List<string> delayTag);
            DelayComboBox.Tag = delayTag;
            ScatterComboBox.DataSource =
                GPSS.DataType.Math.GetDataSource(schema, out List<string> scatterTag);
            ScatterComboBox.Tag = scatterTag;
            DelayComboBox.SelectedIndex = ScatterComboBox.SelectedIndex = -1;

            SaveButton.Click += CreateNewDevice + onSave;
        }

        private void CreateNewDevice(object sender, EventArgs e)
        {
            uint number = uint.Parse(numberComboBox.Text);
            label = LabelTextBox.Text;
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

            if (Validate(name, queue))
            {
                if (chanellCount is null)
                    device = schema.AddDevice(number - 1, center, schema,
                        label, queue, name, delay, scatter);
                else device = schema.AddDevice(number - 1, center, schema, label,
                    queue, name, delay, scatter, chanellCount.Value, transactSize.Value);

                DeleteButton.Enabled = true;
                SaveButton.Click -= CreateNewDevice;
                SaveButton.Click += SaveChanges;
                //device = (GPSS.Visualiztion.Device)schema.Elements[(int)number - 1];
                propertyGrid.SelectedObject = device;
            }
        }
    }
}
