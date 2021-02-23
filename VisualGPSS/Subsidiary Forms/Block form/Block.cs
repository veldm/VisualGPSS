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
        private readonly VisualBlock visualBlock;

        public Block(VisualBlock _visualBlock)
        {
            InitializeComponent();
            visualBlock = _visualBlock;
        }
    }
}
