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
    public partial class Transfer : MaterialSkin.Controls.MaterialForm
    {
        readonly VisualTransfer transfer;
        readonly VisualGPSS_Schema schema;
        readonly VisualBlock startBlock;

        /// <summary>
        /// Открытие формы <see cref="Transfer"/> для редактирования перенаправления
        /// </summary>
        /// <param name="transfer"></param>
        public Transfer(VisualTransfer _transfer)
        {
            InitializeComponent();
            transfer = _transfer;
            schema = transfer.parentSchema;
            TypeCB.SelectedIndex = ((GPSS.Block)transfer.essence).Type switch
            {
                GPSS.Block.BlockType.TRANSFER_UNCON => 0,
                GPSS.Block.BlockType.TRANSFER_BOTH => 1,
                GPSS.Block.BlockType.TRANSFER_VARIABLE => 2,
                GPSS.Block.BlockType.TRANSFER_ALL => 3,
                GPSS.Block.BlockType.TRANSFER_PICK => 4,
                _ => throw new ArgumentException(nameof(transfer.essence)),
            };
            comboBox1.Items.AddRange(schema.LabelsList.ToArray());
            comboBox2.Items.AddRange(schema.LabelsList.ToArray());
            DeleteButton.Enabled = true;
            SaveButton.Click += SaveChanges;
        }

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

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeCB.SelectedIndex)
            {
                case 0:
                    // UNCON
                    Label2.Enabled = comboBox2.Enabled =
                    Label3.Enabled = TextBox.Enabled = false;
                    Label2.Text = Label3.Text = "";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    break;
                case 1:
                    // BOTH
                    Label2.Enabled = comboBox2.Enabled = true;
                    Label3.Enabled = TextBox.Enabled = false;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    comboBox1.Items.Insert(0, "Следующий блок (default)");
                    break;
                case 2:
                    // VAR
                    Label2.Enabled = comboBox2.Enabled = 
                    Label3.Enabled = TextBox.Enabled = true;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "ВЕРОЯТНОСТЬ";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    comboBox1.Items.Insert(0, "Следующий блок (default)");
                    break;
                case 3:
                    // ALL
                    Label2.Enabled = comboBox2.Enabled =
                    Label3.Enabled = TextBox.Enabled = true;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "ДИАПАЗОН";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    TextBox.Text = "1";
                    break;
                case 4:
                    // PICK
                    Label2.Enabled = comboBox2.Enabled = true;
                    Label3.Enabled = TextBox.Enabled = false;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    break;
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            try
            {
                string label1, label2;
                VisualElement Block1, Block2;
                double Digit;

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
                            Block1 = schema.Elements[(int)(transfer.StartBlock.number + 2)];
                        }
                        transfer.Block1 = (VisualBlock)Block1;
                        transfer.essence.Arguments[1] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = (VisualBlock)Block2;
                        transfer.essence.Arguments[2] = label2;

                        // Digit
                        Digit = double.Parse(TextBox.Text);
                        transfer.Digit = Digit;
                        transfer.essence.Arguments[0] = Digit.ToString();
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
                            Block1 = schema.Elements[(int)(transfer.StartBlock.number + 2)];
                        }
                        transfer.Block1 = (VisualBlock)Block1;
                        transfer.essence.Arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = (VisualBlock)Block2;
                        transfer.essence.Arguments[1] = label2;
                        break;
                    case "TRANSFER_UNCON":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        transfer.Block1 = (VisualBlock)Block1;
                        transfer.essence.Arguments[0] = label1;
                        break;
                    case "TRANSFER_ALL":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        transfer.Block1 = (VisualBlock)Block1;
                        transfer.essence.Arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = (VisualBlock)Block2;
                        transfer.essence.Arguments[1] = label1 == label2 ? "" : label2;

                        // Digit
                        Digit = int.Parse(TextBox.Text);
                        transfer.Digit = Digit;
                        transfer.essence.Arguments[2] = Digit is 1 ? "" : Digit.ToString();
                        break;
                    case "TRANSFER_PICK":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        transfer.Block1 = (VisualBlock)Block1;
                        transfer.essence.Arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = (VisualBlock)Block2;
                        transfer.essence.Arguments[1] = label2;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewTransfer(object sender, EventArgs e)
        {
            string labelSelf, typeString, label1, label2;
            VisualElement Block1, Block2;
            double Digit;
            string[] arguments = new string[3];

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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
