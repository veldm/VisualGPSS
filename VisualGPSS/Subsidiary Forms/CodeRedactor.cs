﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class CodeRedactor : MaterialSkin.Controls.MaterialForm
    {
        public CodeRedactor(string[] Code)
        {
            InitializeComponent();
            foreach (string codeString in Code)
            {
                richTextBox1.AppendText($"{codeString}\n");
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() is DialogResult.OK) try
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
                MessageBox.Show($"Файл {saveFileDialog1.FileName} успешно сохранён", "VisualGPSS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}