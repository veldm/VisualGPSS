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
        private List<VisualElement> Elements = new List<VisualElement>();
        private VisualElement activeElement;
        private VisualBlock resizedBlock;
        private bool resizing;
        private (bool isGoing, int xc, int yc) moving;
        private GPSS.Operator creatingOperator;
        public GPSS.Visualiztion.VisualGPSS_Schema schema;

        public Main(string openFileName)
        {
            InitializeComponent();
            if (openFileName is null)
            {
                // Шаблон по умолчанию
                VisualElement V = new VisualBlock(135, 80, new Point(100, 100),
                    Color.SandyBrown, Color.White, ForeColor, Font);
                Elements.Add(V);
            }
            else
            {
                VisualElement V = new VisualBlock(135, 80, new Point(100, 100),
                    Color.SandyBrown, Color.White, ForeColor, Font);
                Elements.Add(V);
                MessageBox.Show(openFileName);
            }
        }

        #region Drag, Drop, Resize
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                if (Cursor.Current.Handle == Cursors.SizeNESW.Handle ||
                    Cursor.Current.Handle == Cursors.SizeNWSE.Handle)
                {
                    Parallel.Invoke(new Action(xResize), new Action(yResize));
                }
                else if (Cursor.Current.Handle == Cursors.SizeWE.Handle) xResize();
                else if (Cursor.Current.Handle == Cursors.SizeNS.Handle) yResize();

                void xResize()
                {
                    int corr = Math.Abs(resizedBlock.center.X - cursorPosition.X) - resizedBlock.width / 2;
                    resizedBlock.width = Math.Abs(resizedBlock.center.X - cursorPosition.X) * 2;
                    resizedBlock.center.X = resizedBlock.center.X < cursorPosition.X ?
                        resizedBlock.center.X + corr : resizedBlock.center.X - corr;
                }

                void yResize()
                {
                    int corr = Math.Abs(resizedBlock.center.Y - cursorPosition.Y) - resizedBlock.heigth / 2;
                    resizedBlock.heigth = Math.Abs(resizedBlock.center.Y - cursorPosition.Y) * 2;
                    resizedBlock.center.Y = resizedBlock.center.Y < cursorPosition.Y ?
                        resizedBlock.center.Y + corr : resizedBlock.center.Y - corr;
                }
            }
            else if (moving.isGoing && activeElement is VisualBlock)
            {
                VisualBlock block = (VisualBlock)activeElement;
                block.center.X = cursorPosition.X + moving.xc;
                block.center.Y = cursorPosition.Y + moving.yc;
            }
            else foreach (VisualElement element in Elements)
                {
                    if (element.IsClicked(cursorPosition))
                    {
                        Cursor.Current = Cursors.Hand;
                        activeElement = element;
                        resizedBlock = null;
                        pictureBox.ContextMenuStrip = BlockOrElementCMS;
                    }
                    else if (element.IsVerticalTouching(cursorPosition))
                    {
                        Cursor.Current = Cursors.SizeWE;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                    }
                    else if (element.IsHorizontalTouching(cursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNS;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                    }
                    else if (element.IsRightDiagonalTouching(cursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNESW;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                    }
                    else if (element.IsLeftDiagonalTouching(cursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNWSE;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                    }
                    else
                    {
                        Cursor.Current = Cursor.Current == Cursors.Cross ?
                            Cursors.Cross : Cursors.Default;
                        activeElement = resizedBlock = null;
                        pictureBox.ContextMenuStrip = FieldCMS;
                    }
                }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (VisualElement element in Elements)
            {
                if (element.IsClicked(cursorPosition)) Cursor.Current = Cursors.Hand;
                else if (element.IsVerticalTouching(cursorPosition)) Cursor.Current = Cursors.SizeWE;
                else if (element.IsHorizontalTouching(cursorPosition)) Cursor.Current = Cursors.SizeNS;
                else if (element.IsRightDiagonalTouching(cursorPosition)) Cursor.Current = Cursors.SizeNESW;
                else if (element.IsLeftDiagonalTouching(cursorPosition)) Cursor.Current = Cursors.SizeNWSE;
                else Cursor.Current = Cursors.Default;
            }
            if (resizedBlock is not null) resizing = true;
            if (activeElement is VisualBlock and not null) moving = (true, 
                    ((VisualBlock)activeElement).center.X - cursorPosition.X,
                    ((VisualBlock)activeElement).center.Y - cursorPosition.Y);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = moving.isGoing = false;
        }
        #endregion Drag, Drop, Resize

        #region Отрисовка
        private void pictureBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cursorPosition.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }
        
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox.Image is not null) pictureBox.Image.Dispose();
            //GC.Collect();
            //Bitmap bitmap = new Bitmap(3510, 2480);
            //pictureBox.Image = bitmap;
            Graphics graphics = /*Graphics.FromImage(bitmap);*/e.Graphics;
            foreach (VisualElement element in Elements)
                element.Draw(graphics);
        }
        #endregion Отрисовка
        
        #region Help & Settings
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

        #endregion Help & Settings

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

        private void сохранитьКакИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(3510, 2480);
            pictureBox.DrawToBitmap(bitmap, new Rectangle(0, 0, 3510, 2480));
            bitmap.Save("buf.png");
            bitmap.Dispose();
            GC.Collect();
        }

        private void ToolBoxItemClicked(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (creatingOperator is not null)
            {
                Cursor = Cursors.Default;
                LabelPictureBox.Focus();
                creatingOperator = null;
            }
            else
            {
                Cursor = Cursors.Cross;
                creatingOperator = control.Name switch
                {
                    _ => new GPSS.Block(),
                };
            }
        }

        private void CreateBlock(object sender, EventArgs e)
        {
            
        }

        private void CreateTransfer(object sender, EventArgs e)
        {
            
        }

        private void CreateCommand(object sender, EventArgs e)
        {
            
        }

        private void RefreshSchema()
        {
            schema.Elements.Sort(new Comparison<VisualElement>((e1, e2)
                => e1.number.CompareTo(e2.number)));

        }
    }
}
