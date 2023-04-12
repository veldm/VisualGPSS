using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private bool Validate(params string[] args)
        {
            if (args[0] is "" || args[1] is "")
            {
                if (MessageBox.Show($"Не задано имя " +
                    $"{(args[0] is "" && args[1] is "" ? "устройства и очереди" : (args[0] is "устройства" ? "" : "очереди"))}" +
                     $"\nВсё равно продолжить?", "Предупреждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) is DialogResult.No) return false;
            }
            else if (args[0] == args[1])
                if (MessageBox.Show("Имя устройства совпадает с именем  очереди" +
                     $"\nВсё равно продолжить?", "Предупреждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) is DialogResult.No) return false;

            foreach (var arg in args)
                if (Regex.IsMatch(arg, @"^\w{1}\d{1}$"))
                    if (MessageBox.Show($"Некорректно задан параметр: " +
                        $"имя \"{arg}\" совпадает с именем системного регистра" +
                            $"\nВсё равно продолжить?", "Предупреждение",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            is DialogResult.No) return false;

            return true;
        }

        private string LastName;
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((QueueTextBox.Text is "" && NameTextBox.Text is not "") 
                || QueueTextBox.Text == $"q{LastName}")
            {
                QueueTextBox.Text = $"q{NameTextBox.Text}";
            }
            LastName = NameTextBox.Text;
            if (NameTextBox.Text is "") QueueTextBox.Text = "";
        }
    }
}
