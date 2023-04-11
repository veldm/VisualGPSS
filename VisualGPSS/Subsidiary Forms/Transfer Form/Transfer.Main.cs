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
        VisualTransfer transfer;
        readonly VisualGPSS_Schema schema;
        readonly VisualElement startBlock;
        string label;


        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeCB.SelectedIndex)
            {
                case 0:
                    // UNCON
                    Label2.Visible = comboBox2.Visible = label2AddButton.Visible =
                    Label3.Visible = FuncComboBox.Visible = TextBox.Visible = false;
                    Label2.Text = Label3.Text = "";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    break;
                case 1:
                    // BOTH
                    Label2.Visible = comboBox2.Visible = label2AddButton.Visible = true;
                    Label3.Visible = FuncComboBox.Visible = TextBox.Visible = false;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    comboBox1.Items.Insert(0, "Следующий блок (default)");
                    break;
                case 2:
                    // VAR
                    Label2.Visible = comboBox2.Visible = label2AddButton.Visible =
                    Label3.Visible = FuncComboBox.Visible = TextBox.Visible = true;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "ВЕРОЯТНОСТЬ";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    comboBox1.Items.Insert(0, "Следующий блок (default)");
                    break;
                case 3:
                    // ALL
                    Label2.Visible = comboBox2.Visible = label2AddButton.Visible =
                    Label3.Visible = FuncComboBox.Visible = TextBox.Visible = true;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "ДИАПАЗОН";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    TextBox.Text = "1";
                    break;
                case 4:
                    // PICK
                    Label2.Visible = comboBox2.Visible = label2AddButton.Visible = true;
                    Label3.Visible = FuncComboBox.Visible = TextBox.Visible = false;
                    Label2.Text = "МЕТКА №2";
                    Label3.Text = "";
                    if (comboBox1.Items.Count > schema.LabelsList.Count)
                        comboBox1.Items.RemoveAt(0);
                    break;
            }
        }

        private void labelAddButton_Click(object sender, EventArgs e)
        {
            addNewElement_CMS.Show((Control)sender, new Point(0, 0));
            addNewElement_CMS.Tag = ((Control)sender).Name;
        }

        private void добавитьВетвлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (transfer is null) transfer = new VisualTransfer() { number = startBlock.number + 1 };
            Transfer transferForm = new (transfer, schema,
                $"label{schema.ElementsWithLabelsList.Count + 1}");
            ComboBox cb = ((ToolStripMenuItem)sender).Owner.Tag switch
            {
                "label1AddButton" => comboBox1,
                "label2AddButton" => comboBox2,
                _ => throw new NotImplementedException()
            };
            transferForm.SaveButton.Click += (object sender, EventArgs e) => 
            {
                cb.Items.Add(transferForm.label);
                cb.SelectedItem = transferForm.label;
                cb.Tag = transferForm.transfer;
            };
            transferForm.Show();
        }

        private void добавитьУстройствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (ComboBox cb, Point center) = ((ToolStripMenuItem)sender).Owner.Tag switch
            {
                "label1AddButton" => (comboBox1,
                    new Point(startBlock.center.X - 200, startBlock.center.Y + 400)),
                "label2AddButton" => (comboBox2,
                    new Point(startBlock.center.X + 200, startBlock.center.Y + 400)),
                _ => throw new NotImplementedException()
            };
            Device deviceForm = new(schema, center,
                label: $"label{schema.ElementsWithLabelsList.Count + 1}", 
                _num: (int)startBlock.number + 2);
            deviceForm.SaveButton.Click += (object sender, EventArgs e) =>
            {
                cb.Items.Add(deviceForm.label);
                cb.SelectedItem = deviceForm.label;
                //SlideDown(startBlock);
            };
            deviceForm.Show();
        }

        private void добавитьБлокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (ComboBox cb, Point center) = ((ToolStripMenuItem)sender).Owner.Tag switch
            {
                "label1AddButton" => (comboBox1,
                    new Point(startBlock.center.X - 200, startBlock.center.Y + 400)),
                "label2AddButton" => (comboBox2,
                    new Point(startBlock.center.X + 200, startBlock.center.Y + 400)),
                _ => throw new NotImplementedException()
            };
            Block blockForm = new(schema, center,
                label: $"label{schema.ElementsWithLabelsList.Count + 1}",
                _num: (int)startBlock.number + 2);
            blockForm.SaveButton.Click += (object sender, EventArgs e) =>
            {
                cb.Items.Add(blockForm.label);
                cb.SelectedItem = blockForm.label;
                //SlideDown(startBlock);
            };
            blockForm.Show();
        }

        private void SlideDown(VisualElement topBlock)
        {
            foreach (VisualElement item in from item in
                                 schema.Elements.Where(a => a.center.Y > topBlock.center.Y)
                                 where item.center.Y - topBlock.center.Y < 500
                                 select item)
            {
                item.center.Y += 500;
            }
        }

        private void FuncComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FuncComboBox.Tag is not null && FuncComboBox.SelectedIndex is not -1)
            {
                TextBox.Text = ((List<string>)FuncComboBox.Tag)[FuncComboBox.SelectedIndex];
                TextBox.Select();
            }
        }
    }
}
