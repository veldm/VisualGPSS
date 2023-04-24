using GPSS.Visualiztion;
using MaterialSkin.Controls;
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
        public string label;

        public Block(VisualGPSS_Schema _schema, Point _point,
            string type = null, string label = null, int? _num = null)
        {
            InitializeComponent();
            schema = _schema;
            point = _point;

            if (type is not null)
                TypeCB.SelectedIndex = TypeCB.Items.IndexOf(type);
            //else TypeCB.SelectedIndex = 0;

            if (label is not null) LabelTextBox.Text = label;

            for (int ii = 0; !(ii > schema.Elements.Count); ii++)
                numberComboBox.Items.Add((ii + 1).ToString());
            //numberComboBox.SelectedIndex = numberComboBox.Items.Count - 1;
            if (_num is null)
                numberComboBox.SelectedIndex = numberComboBox.Items.IndexOf(
                    (schema.GetPlace(point) + 1).ToString());
            else numberComboBox.SelectedIndex = _num.Value - 1;
            //numberComboBox.SelectedIndex = numberComboBox.Items.IndexOf(
            //    (schema.GetPlace(point) + 1).ToString());

            SaveButton.Click += CreateNewBlock;

            //TextBox1.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
            //    (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            //TextBox2.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
            //    (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            //TextBox3.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
            //    (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            //TextBox4.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
            //    (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            //TextBox5.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
            //    (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
        }

        private void CreateNewBlock(object sender, EventArgs e)
        {
            try
            {
                uint number = uint.Parse(numberComboBox.Text);
                string type = TypeCB.Text;
                label = LabelTextBox.Text is "" ? null : LabelTextBox.Text;
                List<string> arguments = new List<string>();
                foreach (var control in from Control control in groupBox2.Controls
                                        where (control
                                        is MaterialSingleLineTextField) && control.Visible
                                        select control)
                {
                    if (control.Text is not "")
                        arguments.Add(control.Text);
                }
                arguments.Reverse();
                string[] args = arguments.ToArray();
                // TODO: Валидация аргументов здесь
                string comment = CommentTextbox.Text is "" ? null : LabelTextBox.Text;

                visualBlock = schema.AddBlock(number - 1, point, type, label, args, comment);

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
