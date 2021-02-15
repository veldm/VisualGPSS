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
        public Transfer(VisualTransfer transfer)
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
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
