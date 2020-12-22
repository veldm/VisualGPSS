using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Main : MaterialForm
    {
        private Point cursorPosition => new Point
            (pictureBox.PointToClient(Cursor.Position).X,
             pictureBox.PointToClient(Cursor.Position).Y);
        private Graphics graphics;
        private List<IVisualElement> Elements = new List<IVisualElement>();

        public Main()
        {
            InitializeComponent();
            IVisualElement V = new VisualBlock(35, 50, new Point(100, 100),
                Color.SandyBrown, Color.White, ForeColor, Font);
            Elements.Add(V);
        }

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

        private void pictureBox_Click(object sender, EventArgs e)
        {;
            MessageBox.Show(cursorPosition.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (IVisualElement element in Elements)
                element.Draw(graphics);
        }
    }
}
