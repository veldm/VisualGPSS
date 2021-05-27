using GPSS.Visualiztion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Block : MaterialSkin.Controls.MaterialForm
    {
        public Block(VisualBlock _visualBlock, VisualGPSS_Schema _schema)
        {
            InitializeComponent();
            visualBlock = _visualBlock;
            schema = _schema;
            SaveButton.Click += SaveChanges;

            //TypeCB.SelectedIndex = visualBlock.Name switch
            //{
            //    "GENERATE" => 0,
            //    "TERMINATE" => 1,
            //    "ADVANCE" => 2,
            //    "SEIZE" => 3,
            //    "RELEASE" => 4,
            //    "QUEUE" => 0,
            //    "DEPART" => 0,
            //    "ENTER" => 0,
            //    "LEAVE" => 0,
            //    _ => throw new NotImplementedException(),
            //};
            TypeCB.SelectedIndex = TypeCB.Items.IndexOf(visualBlock.Name);

            LabelTextBox.Text = visualBlock.Label;
            CommentTextbox.Text = visualBlock.Essence.Comment;
            for (int ii = 0; ii != schema.Elements.Count; ii++)
                numberComboBox.Items.Add(ii.ToString());
            numberComboBox.SelectedItem = (visualBlock.number + 1).ToString();

            TextBox1.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
                (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            TextBox2.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
                (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            TextBox3.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
                (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            TextBox4.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
                (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();
            TextBox5.DataSource = GPSS.PLUS.Base.Functions/*Headers*/.Concat
                (from GPSS.PLUS.Function function in schema.Functions select function.NameToCall).ToList();

            //int i = visualBlock.essence.Arguments.Length - 1;
            //foreach (var control in from Control control in groupBox2.Controls
            //                        where control
            //                        is MaterialSkin.Controls.MaterialSingleLineTextField
            //                        select control)
            //    if (i >= 0) control.Text = visualBlock.essence.Arguments[i--];

            propertyGrid.SelectedObject = visualBlock;
            DeleteButton.Enabled = false;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            try
            {
                if (LabelTextBox.Text != visualBlock.Label)
                {
                    if (schema.Labels.TryGetValue
                        (LabelTextBox.Text, out VisualElement visualElement))
                    {
                        throw new Exception($"Метка {LabelTextBox.Text} уже занята" +
                            $" блоком №{visualElement.number} ({visualElement.Name})");
                    }
                    else visualBlock.Essence.Label = LabelTextBox.Text;
                }

                if (CommentTextbox.Text != visualBlock.Essence.Comment)
                    visualBlock.Essence.Comment = CommentTextbox.Text;

                //int i = 0;
                List<string> args = new List<string>();
                foreach (var control in from Control control in groupBox2.Controls
                                        where control
                                        is MaterialSkin.Controls.MaterialSingleLineTextField
                                        or ComboBox
                                        select control)
                    //visualBlock.essence.Arguments[i++] = control.Text;
                    if (control.Text is not "")
                        args.Add(control.Text);
                visualBlock.Essence.Arguments = args.ToArray();
                schema.Refresh();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
