using GPSS.Visualiztion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Block : MaterialSkin.Controls.MaterialForm
    {

        public Block(VisualGPSS_Schema _schema, Point _point, string type = null)
        {
            InitializeComponent();
            schema = _schema;
            point = _point;

            if (type is not null)
                TypeCB.SelectedIndex = TypeCB.Items.IndexOf(type);
            else TypeCB.SelectedIndex = 0;

            for (int ii = 0; !(ii > schema.Elements.Count); ii++)
                numberComboBox.Items.Add((ii + 1).ToString());
            numberComboBox.SelectedIndex = numberComboBox.Items.Count - 1;

            SaveButton.Click += CreateNewBlock;
        }

        private void CreateNewBlock(object sender, EventArgs e)
        {
            try
            {
                uint number = uint.Parse(numberComboBox.Text);
                string type = TypeCB.Text;
                string label = LabelTextBox.Text is "" ? null : LabelTextBox.Text;
                List<string> arguments = new List<string>();
                foreach (var control in from Control control in groupBox2.Controls
                                        where control
                                        is MaterialSkin.Controls.MaterialSingleLineTextField
                                        select control)
                    arguments.Add(control.Text);
                arguments.Reverse();
                string[] args = arguments.ToArray();
                string comment = CommentTextbox.Text is "" ? null : LabelTextBox.Text;

                schema.AddBlock(number - 1, point, type, label, args, comment);

                visualBlock = (VisualBlock)schema.Elements[(int)(number - 1)];
                SaveButton.Click -= CreateNewBlock;
                SaveButton.Click += SaveChanges;
                propertyGrid.SelectedObject = visualBlock;
                DeleteButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
