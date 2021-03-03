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
        /// Открытие формы <see cref="Transfer"/> для редактирования перенаправления
        /// </summary>
        /// <param name="transfer"></param>
        public Transfer(VisualTransfer _transfer, VisualGPSS_Schema _schema, Main _main)
        {
            InitializeComponent();
            transfer = _transfer;
            schema = _schema;

            TypeCB.SelectedIndex = ((GPSS.Block)transfer.essence).Type switch
            {
                GPSS.Block.BlockType.TRANSFER_UNCON => 0,
                GPSS.Block.BlockType.TRANSFER_BOTH => 1,
                GPSS.Block.BlockType.TRANSFER_VARIABLE => 2,
                GPSS.Block.BlockType.TRANSFER_ALL => 3,
                GPSS.Block.BlockType.TRANSFER_PICK => 4,
                _ => throw new ArgumentException(nameof(transfer.essence)),
            };
            if (comboBox1.Enabled) comboBox1.SelectedItem = transfer.Block1.essence.Label;
            if (comboBox2.Enabled) comboBox2.SelectedItem = transfer.Block2.essence.Label;
            if (TextBox.Enabled) TextBox.Text = transfer.Digit.ToString();

            comboBox1.Items.AddRange(schema.LabelsList.ToArray());
            comboBox2.Items.AddRange(schema.LabelsList.ToArray());
            DeleteButton.Enabled = true;
            SaveButton.Click += SaveChanges;
            propertyGrid.SelectedObject = transfer;
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

                if (transfer.essence.Label != LabelTextBox.Text)
                {
                    if (schema.Labels.TryGetValue(LabelTextBox.Text, out VisualElement visualElement))
                        throw new Exception($"Метка {LabelTextBox.Text} уже занята" +
                        $" блоком №{visualElement.number} ({visualElement.essence.Name})");
                    else transfer.essence.Label = LabelTextBox.Text;
                }

                if (transfer.essence.Comment != CommentTextbox.Text)
                    transfer.essence.Comment = CommentTextbox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
