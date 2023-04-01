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
    public partial class Function : MaterialSkin.Controls.MaterialForm
    {
        private GPSS.Visualiztion.VisualGPSS_Schema schema;

        public Function(GPSS.Visualiztion.VisualGPSS_Schema schema)
        {
            InitializeComponent();
            typeCB.SelectedIndex = 0;
            this.schema = schema;
        }

        private void pointsCountNUD_ValueChanged(object sender, EventArgs e)
        {
            FrqVal_DGV.Enabled = !(pointsCountNUD.Value is 0);
            if (pointsCountNUD.Value > FrqVal_DGV.Rows.Count)
                FrqVal_DGV.Rows.Add(pointsCountNUD.Value - FrqVal_DGV.Rows.Count);
            else if (pointsCountNUD.Value < FrqVal_DGV.Rows.Count)
                for (int i = 0; i < FrqVal_DGV.Rows.Count -pointsCountNUD.Value; i++)
                    FrqVal_DGV.Rows.RemoveAt(FrqVal_DGV.Rows.Count - 1);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTB.Text is not "" ? nameTB.Text :
                    throw new ArgumentException("Не задано имя функции");
                string operand1 = operandTB.Text is not "" ? operandTB.Text :
                    throw new ArgumentException("Не задан опреанд функции");
                #pragma warning disable CS8509
                string type = typeCB.SelectedIndex switch
                #pragma warning restore CS8509
                {
                    0 => "D",
                    1 => "C"
                };
                string operand2 = pointsCountNUD.Value is not 0 ? $"{type}{pointsCountNUD.Value}" :
                    throw new ArgumentException("Функция должна задавать хотя бы одну точку");
                List<KeyValuePair<string, string>> values = new List<KeyValuePair<string, string>>();
                foreach (DataGridViewRow row in FrqVal_DGV.Rows)
                {
                    values.Add(new KeyValuePair<string, string>
                        ((string)row.Cells[0].Value, (string)row.Cells[1].Value));
                }
                schema.AddFunction(name, operand1, operand2, values);
            }
            catch (Exception)
            {
                MessageBox.Show("Значения повторяются", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
