using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS.Subsidiary_Forms
{
    public partial class Function : MaterialSkin.Controls.MaterialForm
    {
        public Function()
        {
            InitializeComponent();
        }

        private void pointsCountNUD_ValueChanged(object sender, EventArgs e)
        {
            FrqVal_DGV.Enabled = !(pointsCountNUD.Value is 0);
            if (pointsCountNUD.Value > FrqVal_DGV.Rows.Count)
                FrqVal_DGV.Rows.Add(pointsCountNUD.Value - FrqVal_DGV.Rows.Count);
            else if (pointsCountNUD.Value < FrqVal_DGV.Rows.Count)
                for (int i = 0; i < FrqVal_DGV.Rows.Count -pointsCountNUD.Value; i++)
                    FrqVal_DGV.Rows.RemoveAt(FrqVal_DGV.Rows.Count);
        }


    }
}
