﻿using GPSS.Visualiztion;
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

        private delegate void Creator(object param, Point point);
        private (Creator method, object parameter)? creatingOperator;

        public VisualGPSS_Schema schema;
        private string filePath;
        #endregion Поля

        public Main(string openFileName = null)
        {
            InitializeComponent();
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
            if (schema is null) return;
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
                        pictureBox.Image = bitmap.Clone(new Rectangle(hScrollBar1.Value,
                            vScrollBar1.Value, pictureBox.Width, pictureBox.Height),
                            bitmap.PixelFormat);
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
    }
}