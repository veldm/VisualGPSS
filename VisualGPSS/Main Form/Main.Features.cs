using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        #region Фичи
        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.ForeColor = Color.LightBlue;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.ForeColor = Color.White;
        }

        private void helpButton_MouseEnter(object sender, EventArgs e)
        {
            helpButton.ForeColor = Color.LightBlue;
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            helpButton.ForeColor = Color.White;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Настройки");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справка");
        }

        private void сохранитьКакИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(RightBottom.X, RightBottom.Y);
            pictureBox.DrawToBitmap(bitmap, new Rectangle(0, 0, RightBottom.X, RightBottom.Y));
            bitmap.Save("buf.png");
            bitmap.Dispose();
            GC.Collect();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (schemaSaveFileDialog.ShowDialog() is DialogResult.OK)
            {
                try
                {
                    string saveFileName = schemaSaveFileDialog.FileName;
                    schema.Serialize(saveFileName);
                    MessageBox.Show($"Файл {saveFileName} успешно сохранён", "VisualGPSS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath is not null) schema.Serialize(filePath);
            else сохранитьКакToolStripMenuItem_Click(sender, e);
        }

        private void генерацияКодаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeRedactor redactor = new CodeRedactor(schema.Code);
            redactor.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schema.Remove(activeElement);
            graphicsRefresh(sender, e);
        }

        #endregion Фичи
    }
}
