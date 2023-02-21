using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPSS.Visualiztion;

namespace VisualGPSS
{
    public partial class Device : MaterialSkin.Controls.MaterialForm
    {
        private GPSS.Visualiztion.Device device;
        private readonly VisualGPSS_Schema schema;
        private readonly Point center;
        public EventHandler onSave;

        private void multiChanellCB_CheckedChanged(object sender, EventArgs e)
        {
            ChanellCountCB.Enabled = transactSizeCB.Enabled = multiChanellCB.Checked;
        }

        private void DelayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelayComboBox.Tag is not null && DelayComboBox.SelectedIndex is not -1)
            {
                DelayTextBox.Text = ((List<string>)DelayComboBox.Tag)[DelayComboBox.SelectedIndex];
                DelayTextBox.Select();
            }
        }

        private void ScatterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScatterComboBox.Tag is not null && ScatterComboBox.SelectedIndex is not -1)
            {
                ScatterTextBox.Text = ((List<string>)ScatterComboBox.Tag)[ScatterComboBox.SelectedIndex];
                ScatterTextBox.Select();
            }
        }
    }
}
