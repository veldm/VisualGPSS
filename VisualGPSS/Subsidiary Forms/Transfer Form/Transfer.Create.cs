using GPSS.Visualiztion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Transfer : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Открытие формы <see cref="Transfer"/> для создания нового перенаправления
        /// </summary>
        /// <param name="_startBlock"></param>
        public Transfer(VisualBlock _startBlock)
        {
            InitializeComponent();
            startBlock = _startBlock;
            schema = startBlock.parentSchema;
            DeleteButton.Enabled = false;
            TypeCB.SelectedIndex = 0;
            SaveButton.Click += CreateNewTransfer;
        }

        private void CreateNewTransfer(object sender, EventArgs e)
        {
            string labelSelf, typeString, label1, label2, comment;
            string[] arguments = new string[3];
            VisualElement Block1 = null, Block2 = null;
            double Digit = 0;

            try
            {
                switch (transfer.essence.Name)
                {
                    case "TRANSFER_VARIABLE":
                        // Block1
                        if (comboBox1.SelectedIndex is 0)
                        {
                            label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                            if (!schema.Labels.TryGetValue(label1, out Block1))
                                throw new Exception($"Метки {label1} не существует");
                        }
                        else
                        {
                            label1 = "";
                            Block1 = schema.Elements[(int)(startBlock.number + 2)];
                        }
                        arguments[1] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        arguments[2] = label2;

                        // Digit
                        Digit = double.Parse(TextBox.Text);
                        arguments[0] = Digit.ToString();
                        break;
                    case "TRANSFER_BOTH":
                        // Block1
                        if (comboBox1.SelectedIndex is 0)
                        {
                            label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                            if (!schema.Labels.TryGetValue(label1, out Block1))
                                throw new Exception($"Метки {label1} не существует");
                        }
                        else
                        {
                            label1 = "";
                            Block1 = schema.Elements[(int)(startBlock.number + 2)];
                        }
                        arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        arguments[1] = label2;
                        break;
                    case "TRANSFER_UNCON":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        arguments[0] = label1;
                        break;
                    case "TRANSFER_ALL":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        arguments[1] = label1 == label2 ? "" : label2;

                        // Digit
                        Digit = int.Parse(TextBox.Text);
                        arguments[2] = Digit is 1 ? "" : Digit.ToString();
                        break;
                    case "TRANSFER_PICK":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        arguments[1] = label2;
                        break;
                }

                labelSelf = LabelTextBox.Text;
                if (schema.Labels.TryGetValue(labelSelf, out VisualElement visualElement))
                    throw new Exception($"Метка {labelSelf} уже занята" +
                        $" блоком {visualElement.essence.Name}");

                List<string> args = arguments.ToList();
                foreach (string item in args) if (item is null) args.Remove(item);
                arguments = args.ToArray();

                typeString = transfer.essence.Name;

                comment = CommentTextbox.Text;

                schema.AddTransfer(typeString, startBlock, (VisualBlock)Block1, (VisualBlock)Block2, Digit, labelSelf, arguments, comment);

                propertyGrid.SelectedObject = schema.Elements[(int)startBlock.number + 1];
                SaveButton.Click -= CreateNewTransfer;
                SaveButton.Click += SaveChanges;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
