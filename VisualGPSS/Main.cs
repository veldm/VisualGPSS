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
        #region Поля
        private Point CursorPosition => new Point()
        { 
            X = pictureBox.PointToClient(Cursor.Position).X,
            Y = pictureBox.PointToClient(Cursor.Position).Y
        };

        private VisualElement activeElement;
        private VisualBlock resizedBlock;
        private bool resizing;
        private (bool isGoing, int xc, int yc) moving;

        private delegate void Creator(string type);
        private (Creator method, string parameter)? creatingOperator;

        public VisualGPSS_Schema schema;
        #endregion Поля

        public Main(string openFileName)
        {
            InitializeComponent();
            schema = new VisualGPSS_Schema(Font, ForeColor, pictureBox.BackColor);
            if (openFileName is null)
            {
                // Шаблон по умолчанию
                VisualElement V = new VisualBlock(135, 80, new Point(100, 100),
                    Color.SandyBrown, Color.White, ForeColor, Font);
                schema.Elements.Add(V);
            }
            else
            {
                VisualElement V = new VisualBlock(135, 80, new Point(100, 100),
                    Color.SandyBrown, Color.White, ForeColor, Font);
                schema.Elements.Add(V);
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
                    int corr = Math.Abs(resizedBlock.center.X - CursorPosition.X) - resizedBlock.width / 2;
                    resizedBlock.width = Math.Abs(resizedBlock.center.X - CursorPosition.X) * 2;
                    resizedBlock.center.X = resizedBlock.center.X < CursorPosition.X ?
                        resizedBlock.center.X + corr : resizedBlock.center.X - corr;
                }

                void yResize()
                {
                    int corr = Math.Abs(resizedBlock.center.Y - CursorPosition.Y) - resizedBlock.heigth / 2;
                    resizedBlock.heigth = Math.Abs(resizedBlock.center.Y - CursorPosition.Y) * 2;
                    resizedBlock.center.Y = resizedBlock.center.Y < CursorPosition.Y ?
                        resizedBlock.center.Y + corr : resizedBlock.center.Y - corr;
                }
            }
            else if (moving.isGoing && activeElement is VisualBlock)
            {
                VisualBlock block = (VisualBlock)activeElement;
                block.center.X = CursorPosition.X + moving.xc;
                block.center.Y = CursorPosition.Y + moving.yc;
            }
            else foreach (VisualElement element in schema.Elements)
                {
                    if (element.IsClicked(CursorPosition))
                    {
                        Cursor.Current = Cursors.Hand;
                        activeElement = element;
                        resizedBlock = null;
                        pictureBox.ContextMenuStrip = BlockOrElementCMS;
                    }
                    else if (element.IsVerticalTouching(CursorPosition))
                    {
                        Cursor.Current = Cursors.SizeWE;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                    }
                    else if (element.IsHorizontalTouching(CursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNS;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                    }
                    else if (element.IsRightDiagonalTouching(CursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNESW;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                    }
                    else if (element.IsLeftDiagonalTouching(CursorPosition))
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
            foreach (VisualElement element in schema.Elements)
            {
                if (element.IsClicked(CursorPosition)) Cursor.Current = Cursors.Hand;
                else if (element.IsVerticalTouching(CursorPosition)) Cursor.Current = Cursors.SizeWE;
                else if (element.IsHorizontalTouching(CursorPosition)) Cursor.Current = Cursors.SizeNS;
                else if (element.IsRightDiagonalTouching(CursorPosition)) Cursor.Current = Cursors.SizeNESW;
                else if (element.IsLeftDiagonalTouching(CursorPosition)) Cursor.Current = Cursors.SizeNWSE;
                else Cursor.Current = Cursors.Default;
            }
            if (resizedBlock is not null) resizing = true;
            if (activeElement is VisualBlock and not null) moving = (true, 
                    ((VisualBlock)activeElement).center.X - CursorPosition.X,
                    ((VisualBlock)activeElement).center.Y - CursorPosition.Y);
            propertyGrid.SelectedObject = (activeElement is null) switch
            {
                false => activeElement,
                true => schema
            };
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = moving.isGoing = false;
            if (creatingOperator is not null)
                creatingOperator.Value.method.Invoke(creatingOperator.Value.parameter);
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
            Graphics graphics = e.Graphics; /*Graphics.FromImage(bitmap);*/
            //foreach (VisualElement element in Elements)
            //    element.Draw(graphics);
            schema.Draw(graphics);
        }
        #endregion Отрисовка
        
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
            Bitmap bitmap = new Bitmap(3510, 2480);
            pictureBox.DrawToBitmap(bitmap, new Rectangle(0, 0, 3510, 2480));
            bitmap.Save("buf.png");
            bitmap.Dispose();
            GC.Collect();
        }

        #endregion Фичи

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

        #region Создание операторов и обновление схемы

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
                    _ => null
                };
            }
        }

        private void CreateBlock(string type)
        {
            
        }

        private void CreateTransfer(string type)
        {
            
        }

        private void CreateCommand(string type)
        {
            
        }

        private void RefreshSchema()
        {
            schema.Elements.Sort(new Comparison<VisualElement>((e1, e2)
                => e1.number.CompareTo(e2.number)));

            foreach (VisualElement element in schema.Elements.Where
                (element => element is VisualTransfer))
            {
                int index1 = schema.Elements.IndexOf(element);
                int index2 = schema.Elements.IndexOf(((VisualTransfer)element).StartBlock);
                if (index2 != index1 - 1)
                {
                    VisualElement buf = schema.Elements[index1 - 1];
                    schema.Elements[index1 - 1] = ((VisualTransfer)element).StartBlock;
                    schema.Elements[index2] = buf;
                }
            }

            for (int i = 0; i < schema.Elements.Count; i++)
                schema.Elements[i].number = (uint)i;
        }

        #endregion Создание операторов и обновление схемы
    }
}
