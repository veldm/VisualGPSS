using GPSS;
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

            TypeCB.SelectedIndex = ((GPSS.Block)transfer.Essence).Type switch
            {
                GPSS.Block.BlockType.TRANSFER_UNCON => 0,
                GPSS.Block.BlockType.TRANSFER_BOTH => 1,
                GPSS.Block.BlockType.TRANSFER_VARIABLE => 2,
                GPSS.Block.BlockType.TRANSFER_ALL => 3,
                GPSS.Block.BlockType.TRANSFER_PICK => 4,
                _ => throw new ArgumentException(nameof(transfer.Essence)),
            };
            comboBox1.Items.AddRange(schema.LabelsList.ToArray());
            if (comboBox1.Enabled) comboBox1.SelectedItem = transfer.Block1.Label;
            comboBox2.Items.AddRange(schema.LabelsList.ToArray());
            if (comboBox2.Enabled) comboBox2.SelectedItem = transfer.Block2.Label;
            if (TextBox.Enabled)
            {
                if (transfer.Digit is not 0) TextBox.Text = transfer.Digit.ToString();
                else TextBox.Text = transfer.Essence.Arguments
                        [TypeCB.SelectedIndex is 2 ? 0 : 2];
            }

            DeleteButton.Enabled = true;
            SaveButton.Click += SaveChanges;
            propertyGrid.SelectedObject = transfer;
            FuncComboBox.DataSource = DataType.Math.GetDataSource(schema, out List<string> tag);
            FuncComboBox.Tag = tag;
            FuncComboBox.SelectedIndex = -1;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            try
            {
                string label1, label2;
                VisualElement Block1, Block2;
                double Digit;

                switch (transfer.Name)
                {
                    case "TRANSFER_VARIABLE":
                        // Block1
                        if (comboBox1.SelectedIndex is 0)
                        {
                            label1 = "";
                            Block1 = schema.Elements[(int)(transfer.StartBlock.number + 2)];
                        }
                        else
                        {
                            label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                            if (!schema.Labels.TryGetValue(label1, out Block1))
                                throw new Exception($"Метки {label1} не существует");
                        }
                        transfer.Block1 = Block1;
                        transfer.Essence.Arguments[1] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label2, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = Block2;
                        transfer.Essence.Arguments[2] = label2;

                        // Digit
                        if (FuncComboBox.SelectedIndex is -1)
                        {
                            Digit = double.Parse(TextBox.Text.Replace('.', ','));
                            transfer.Digit = Digit;
                            transfer.Essence.Arguments[0] = Digit.ToString();
                        }
                        else transfer.Essence.Arguments[0] = TextBox.Text;
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
                        transfer.Block1 = Block1;
                        transfer.Essence.Arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = Block2;
                        transfer.Essence.Arguments[1] = label2;
                        break;
                    case "TRANSFER_UNCON":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        transfer.Block1 = Block1;
                        transfer.Essence.Arguments[0] = label1;
                        break;
                    case "TRANSFER_ALL":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        transfer.Block1 = Block1;
                        transfer.Essence.Arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = Block2;
                        transfer.Essence.Arguments[1] = label1 == label2 ? "" : label2;

                        // Digit
                        if (FuncComboBox.SelectedIndex is -1)
                        {
                            Digit = double.Parse(TextBox.Text.Replace('.', ','));
                            transfer.Essence.Arguments[2] = Digit.ToString();
                        }
                        else transfer.Essence.Arguments[2] = TextBox.Text;
                        break;
                    case "TRANSFER_PICK":
                        // Block1
                        label1 = (string)comboBox1.Items[comboBox1.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label1, out Block1))
                            throw new Exception($"Метки {label1} не существует");
                        transfer.Block1 = Block1;
                        transfer.Essence.Arguments[0] = label1;

                        // Block2
                        label2 = (string)comboBox2.Items[comboBox2.SelectedIndex];
                        if (!schema.Labels.TryGetValue(label2, out Block2))
                            throw new Exception($"Метки {label2} не существует");
                        transfer.Block2 = Block2;
                        transfer.Essence.Arguments[1] = label2;
                        break;
                }

                if (transfer.Label != LabelTextBox.Text)
                {
                    if (schema.Labels.TryGetValue(LabelTextBox.Text, out VisualElement visualElement))
                        throw new Exception($"Метка {LabelTextBox.Text} уже занята" +
                        $" блоком №{visualElement.number} ({visualElement.Name})");
                    else transfer.Essence.Label = LabelTextBox.Text;
                }

                if (transfer.Essence.Comment != CommentTextbox.Text)
                    transfer.Essence.Comment = CommentTextbox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
