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
    public partial class Table : MaterialSkin.Controls.MaterialForm
    {
        private GPSS.Visualiztion.VisualGPSS_Schema schema;

        public Table(GPSS.Visualiztion.VisualGPSS_Schema schema)
        {
            InitializeComponent();
            this.schema = schema;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTB.Text is not "" ? nameTB.Text :
                    throw new ArgumentException("Таблица не может быть безымянной");
                string maximum = maxTB.Text is not "" ? maxTB.Text :
                    throw new ArgumentException("Задайте необходимые параметры");
                string width = widthTB.Text is not "" ? widthTB.Text :
                    throw new ArgumentException("Задайте необходимые параметры");
                string count = countTB.Text is not "" ? countTB.Text :
                    throw new ArgumentException("Задайте необходимые параметры");
                string RT_time = RT_timeTB.Text is not "" ? RT_timeTB.Text : null;
                schema.AddTable(name, maximum, width, count, RT_time);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
