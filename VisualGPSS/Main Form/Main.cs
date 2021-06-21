using GPSS.Visualiztion;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGPSS
{
    public partial class Main : MaterialForm
    {
        #region Поля
        private Point CursorPosition => new Point()
        {
            X = pictureBox.PointToClient(Cursor.Position).X + hScrollBar1.Value,
            Y = pictureBox.PointToClient(Cursor.Position).Y + vScrollBar1.Value

            //X = (int)((pictureBox.PointToClient(Cursor.Position).X + hScrollBar1.Value) * scale),
            //Y = (int)((pictureBox.PointToClient(Cursor.Position).Y + vScrollBar1.Value) * scale)
        };

        private Point RightBottom
        {
            get
            {
                int x, y,
                minX = int.MaxValue, minY = int.MaxValue,
                maxX = int.MinValue, maxY = int.MinValue;
                foreach (VisualElement element in schema.Elements)
                {
                    if (element is VisualBlock block)
                    {
                        if (block.center.X + block.width / 2 > maxX)
                            maxX = block.center.X + block.width / 2;
                        if (block.center.X - block.width / 2 < minX)
                            minX = block.center.X - block.width / 2;
                        if (block.center.Y + block.heigth / 2 > maxY)
                            maxY = block.center.Y + block.heigth / 2;
                        if (block.center.Y - block.heigth / 2 < minY)
                            minY = block.center.Y + block.heigth / 2;
                    }
                }

                x = maxX + minX;
                y = maxY + minY;
                return new Point(x, y);
            }
        }

        private VisualElement activeElement;
        private VisualBlock resizedBlock;
        private bool resizing;
        private (bool isGoing, int xc, int yc) moving;
        private Bitmap bitmap;
        double scale = 1;

        private delegate void Creator(object param, Point point);
        private (Creator method, object parameter)? creatingOperator;

        public VisualGPSS_Schema schema;
        private string filePath;
        #endregion Поля

        public Main(string openFileName = null)
        {
            InitializeComponent();
            открытьToolStripMenuItem.Click += graphicsRefresh;
            Show();
            filePath = openFileName;
            //typeof(Panel).InvokeMember("DoubleBuffered",
            //    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //    null, DrawingContainer, new object[] { true });
            if (openFileName is null)
            {
                if (MessageBox.Show("Загрузить схему по умолчанию?", "VisualGPSS",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) is DialogResult.Yes)
                {
                    // Шаблон по умолчанию
                    schema = VisualGPSS_Schema.getDefaultSchema(Font, Color.Black,
                        pictureBox.BackColor, Color.SandyBrown, Color.MediumBlue);
                }
                else schema = new VisualGPSS_Schema(Font, Color.Black,
                        pictureBox.BackColor, Color.SandyBrown, Color.MediumBlue);
            }
            else
            {
                schema = VisualGPSS_Schema.Deserialize(openFileName);

                //VisualElement V = new VisualBlock(135, 80, new Point(100, 100),
                //    Color.SandyBrown, Color.White, ForeColor, Font);
                //schema.Elements.Add(V);
                //MessageBox.Show(openFileName);
            }
            //pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphicsRefresh(null, null);
        }

        #region Отрисовка

        public void graphicsRefresh(object sender, EventArgs e)
        {
            if (schema is null || pictureBox.Width is 0 || pictureBox.Height is 0) return;
            using (bitmap = new Bitmap(pictureBox.Width + hScrollBar1.Value,
                pictureBox.Height + vScrollBar1.Value))
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                if (timer.Enabled)
                {
                    timer.Stop();
                    schema.Draw(graphics);
                    timer.Start();
                }
                else schema.Draw(graphics);

                using (Bitmap buf = (Bitmap)pictureBox.Image)
                {
                    GC.Collect();
                    lock (bitmap)
                    {
                        Bitmap _bitmap = new Bitmap(bitmap, new Size
                            ((int)(bitmap.Width * scale), (int)(bitmap.Height * scale)));
                        pictureBox.Image = _bitmap.Clone(new Rectangle(hScrollBar1.Value,
                            vScrollBar1.Value, pictureBox.Width, pictureBox.Height),
                            bitmap.PixelFormat);
                        _bitmap.Dispose();
                        pictureBox.Refresh();
                    }
                }
                GC.Collect();
                //for (int i = 0; i < pictureBox.Width; i++)
                //{
                //    for (int j = 0; j < pictureBox.Height; j++)
                //    {
                //        ((Bitmap)pictureBox.Image).SetPixel
                //            (i, j, bitmap.GetPixel(i + hScrollBar1.Value, j + vScrollBar1.Value));
                //    }
                //}
                //pictureBox.Image.Dispose();
            }
            GC.Collect();
            //pictureBox.Invalidate(new Rectangle(0, 0, RightBottom.X + 150, RightBottom.Y + 150));
        }

        #endregion Отрисовка

        #region Цвета меню
        private void файлToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            файлToolStripMenuItem.ForeColor = Color.Black;
        }

        private void файлToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            файлToolStripMenuItem.ForeColor = Color.White;
        }

        private void средстваToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            средстваToolStripMenuItem.ForeColor = Color.Black;
        }

        private void средстваToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            средстваToolStripMenuItem.ForeColor = Color.White;
        }
        #endregion Цвета меню        

        #region Custom Controls

        private class CustomPictureBox : PictureBox
        {
            public CustomPictureBox() : base()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
            }
        }

        private class CustomPanel : Panel
        {
            public CustomPanel() : base()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
            }
        }

        #endregion Custom Controls

        private void functionButton_Click(object sender, EventArgs e)
        {
            Function function = new Function(schema);
            function.Show();
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            Table table = new Table(schema);
            table.Show();
        }

        private void ToolBoxItemClicked(object sender, EventArgs e)
        {

        }

        private void EditElement(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void генерацияКодаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpScale(object sender, EventArgs e)
        {

        }

        private void DownScale(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddTransfer(object sender, EventArgs e)
        {

        }
    }
}
