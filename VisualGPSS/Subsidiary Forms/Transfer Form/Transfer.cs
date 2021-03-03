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
    }
}
