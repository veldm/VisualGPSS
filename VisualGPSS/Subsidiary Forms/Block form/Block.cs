using GPSS.Visualiztion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Block : MaterialSkin.Controls.MaterialForm
    {
        private VisualBlock visualBlock;
        private readonly Point point;
        private readonly VisualGPSS_Schema schema;

        public Block(VisualBlock _visualBlock)
        {
            InitializeComponent();
            visualBlock = _visualBlock;
            SaveButton.Click += SaveChanges;

            //TypeCB.SelectedIndex = visualBlock.essence.Name switch
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
            TypeCB.SelectedIndex = TypeCB.Items.IndexOf(visualBlock.essence.Name);

            LabelTextBox.Text = visualBlock.essence.Label;
            CommentTextbox.Text = visualBlock.essence.Comment;
            for (int ii = 0; ii != visualBlock.parentSchema.Elements.Count; ii++)
                numberComboBox.Items.Add(ii.ToString());
            numberComboBox.SelectedItem = visualBlock.number.ToString();

            //if (TextBox1.Enabled) TextBox1.Text = visualBlock.essence.Arguments[0];
            //if (TextBox2.Enabled) TextBox2.Text = visualBlock.essence.Arguments[1];
            //if (TextBox3.Enabled) TextBox3.Text = visualBlock.essence.Arguments[2];
            //if (TextBox4.Enabled) TextBox4.Text = visualBlock.essence.Arguments[3];
            //if (TextBox5.Enabled) TextBox5.Text = visualBlock.essence.Arguments[4];
            int i = 0;
            foreach (var control in from Control control in groupBox2.Controls
                                    where control
                                    is MaterialSkin.Controls.MaterialSingleLineTextField
                                    select control)
                    control.Text = visualBlock.essence.Arguments[i++];

            propertyGrid.SelectedObject = visualBlock;
            DeleteButton.Enabled = false;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            try
            {
                if (LabelTextBox.Text != visualBlock.essence.Label)
                {
                    if (visualBlock.parentSchema.Labels.TryGetValue
                        (LabelTextBox.Text, out VisualElement visualElement))
                    {
                        throw new Exception($"Метка {LabelTextBox.Text} уже занята" +
                            $" блоком №{visualElement.number} ({visualElement.essence.Name})");
                    }
                    else visualBlock.essence.Label = LabelTextBox.Text;
                }

                if (CommentTextbox.Text != visualBlock.essence.Comment)
                    visualBlock.essence.Comment = CommentTextbox.Text;

                int i = 0;
                foreach (var control in from Control control in groupBox2.Controls
                                        where control
                                        is MaterialSkin.Controls.MaterialSingleLineTextField
                                        select control)
                    visualBlock.essence.Arguments[i++] = control.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Block(VisualGPSS_Schema _schema, Point _point, string type = null)
        {
            InitializeComponent();
            schema = _schema;
            point = _point;

            if (type is not null)
                TypeCB.SelectedIndex = TypeCB.Items.IndexOf(type);
            else TypeCB.SelectedIndex = 0;

            for (int ii = 0; ii != schema.Elements.Count; ii++)
                numberComboBox.Items.Add(ii.ToString());
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
                int i = 0;
                foreach (var control in from Control control in groupBox2.Controls
                                        where control
                                        is MaterialSkin.Controls.MaterialSingleLineTextField
                                        select control)
                    arguments.Add(control.Text);
                string[] args = arguments.ToArray();
                string comment = CommentTextbox.Text is "" ? null : LabelTextBox.Text;

                schema.AddBlock(number, point, type, label, args, comment);

                visualBlock = (VisualBlock)schema.Elements[(int)number];
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

        //  GENERATE[〈интервал〉],[〈разброс〉],[〈задержка〉],[〈ограничение〉],[〈приоритет〉
        //  TERMINATE [hвычитаемоеi]
        //  ADVANCE[hинтервалi],[hразбросi]
        //  SEIZE hимя устройстваi
        //  RELEASE hимя устройстваi
        //  QUEUE hимя очередиi[, hколичествоi]
        //  DEPART hимя очередиi[, hколичествоi]
        //  ENTER hимяi,[hколичествоi]
        //  LEAVE hимяi,[hколичествоi]

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeCB.SelectedItem)
            {
                case "GENERATE":
                    SetParams("ИНТЕРВАЛ", "РАЗБРОС", "ЗАДЕРЖКА", "ОГРАНИЧЕНИЕ", "ПРИОРИТЕТ");
                    break;
                case "TERMINATE":
                    SetParams("ВЫЧИТАЕМОЕ");
                    break;
                case "ADVANCE":
                    SetParams("ИНТЕРВАЛ", "РАЗБРОС");
                    break;
                case "SEIZE":
                    SetParams("УСТРОЙСТВО");
                    break;
                case "RELEASE":
                    SetParams("УСТРОЙСТВО");
                    break;
                case "QUEUE":
                    SetParams("ОЧЕРЕДЬ", "КОЛИЧЕСТВО");
                    break;
                case "DEPART":
                    SetParams("ОЧЕРЕДЬ", "КОЛИЧЕСТВО");
                    break;
                case "ENTER":
                    SetParams("УСТРОЙСТВО", "КОЛИЧЕСТВО");
                    break;
                case "LEAVE":
                    SetParams("УСТРОЙСТВО", "КОЛИЧЕСТВО");
                    break;
            }

            void SetParams(string s1, string s2 = "", string s3 = "", string s4 = "", string s5 = "")
            {
                // 1
                Label1.Text = s1;
                TextBox1.Enabled = s1 is "";

                // 2
                Label2.Text = s2;
                TextBox2.Enabled = s2 is "";

                // 3
                Label3.Text = s3;
                TextBox3.Enabled = s3 is "";

                // 4
                Label4.Text = s4;
                TextBox4.Enabled = s4 is "";

                // 5
                Label5.Text = s5;
                TextBox5.Enabled = s5 is "";
            }
        }
    }
}
