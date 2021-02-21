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
        public Transfer(VisualTransfer transfer, VisualGPSS_Schema schema)
        {
            InitializeComponent();
            TypeCB.SelectedIndex = ((GPSS.Block)transfer.essence).Type switch
            {
                GPSS.Block.BlockType.TRANSFER_UNCON => 0,
                GPSS.Block.BlockType.TRANSFER_BOTH => 1,
                GPSS.Block.BlockType.TRANSFER_VARIABLE => 2,
                GPSS.Block.BlockType.TRANSFER_ALL => 3,
                GPSS.Block.BlockType.TRANSFER_PICK => 4,
                _ => throw new NotImplementedException(),
            };
            comboBox1.Items.AddRange(schema.LabelsList.ToArray());
            comboBox2.Items.AddRange(schema.LabelsList.ToArray());
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeCB.SelectedIndex)
            {
                case 0:
                    CheckBox1.Enabled =
                        Label2.Enabled = CheckBox2.Enabled = comboBox2.Enabled =
                        Label3.Enabled = CheckBox3.Enabled = TextBox.Enabled = false;
                    Label2.Text = Label3.Text = "";
                    comboBox1.SelectedIndex = 0;
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }
    }
}
