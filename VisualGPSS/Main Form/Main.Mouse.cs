using GPSS.Visualiztion;
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
        #region Мышь
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
            else if (moving.isGoing /*&& activeElement is VisualBlock bufferBlock*/)
            {
                //VisualBlock block = bufferBlock;
                //block.center.X = CursorPosition.X + moving.xc;
                //block.center.Y = CursorPosition.Y + moving.yc;

                activeElement.center.X = CursorPosition.X + moving.xc;
                activeElement.center.Y = CursorPosition.Y + moving.yc;
            }
            else foreach (VisualElement element in schema.Elements)
                {
                    if (element.IsClicked(CursorPosition))
                    {
                        Cursor.Current = Cursors.Hand;
                        activeElement = element;
                        resizedBlock = null;
                        pictureBox.ContextMenuStrip = BlockOrElementCMS;
                        break;
                    }
                    else if (element.IsVerticalTouching(CursorPosition))
                    {
                        Cursor.Current = Cursors.SizeWE;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                        break;
                    }
                    else if (element.IsHorizontalTouching(CursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNS;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                        break;
                    }
                    else if (element.IsRightDiagonalTouching(CursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNESW;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                        break;
                    }
                    else if (element.IsLeftDiagonalTouching(CursorPosition))
                    {
                        Cursor.Current = Cursors.SizeNWSE;
                        resizedBlock = element is VisualBlock block ? block : null;
                        activeElement = null;
                        break;
                    }
                    else
                    {
                        Cursor.Current = Cursor.Current == Cursors.Cross ?
                            Cursors.Cross : Cursors.Default;
                        activeElement = resizedBlock = null;
                        pictureBox.ContextMenuStrip = null;
                    }
                }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (VisualElement element in schema.Elements)
            {
                if (element.IsClicked(CursorPosition))
                {
                    Cursor.Current = Cursors.Hand;
                    break;
                }
                else if (element.IsVerticalTouching(CursorPosition))
                {
                    Cursor.Current = Cursors.SizeWE;
                    break;
                }
                else if (element.IsHorizontalTouching(CursorPosition))
                {
                    Cursor.Current = Cursors.SizeNS;
                    break;
                }
                else if (element.IsRightDiagonalTouching(CursorPosition))
                {
                    Cursor.Current = Cursors.SizeNESW;
                    break;
                }
                else if (element.IsLeftDiagonalTouching(CursorPosition))
                {
                    Cursor.Current = Cursors.SizeNWSE;
                    break;
                }
                else Cursor.Current = Cursors.Default;
            }
            if (resizedBlock is not null)
            {
                resizing = true;
                timer.Start();
            }
            if (activeElement is VisualBlock and not null)
            {
                moving = (true,
                    ((VisualBlock)activeElement).center.X - CursorPosition.X,
                    ((VisualBlock)activeElement).center.Y - CursorPosition.Y);
                timer.Start();
            }
            propertyGrid.SelectedObject = (activeElement is null) switch
            {
                false => activeElement,
                true => schema
            };
            //if (Cursor.Current == Cursors.Cross)
            //{
            //    Cursor.Current = Cursors.Default;
            //    creatingOperator.Value.method.Invoke
            //        (creatingOperator.Value.parameter, CursorPosition);
            //}
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = moving.isGoing = false;
            timer.Stop();
            timer.Enabled = false;
            if (/*Cursor.Current == Cursors.Cross &&*/ creatingOperator is not null)
                creatingOperator.Value.method.Invoke(creatingOperator.Value.parameter,
                    new Point(CursorPosition.X, CursorPosition.Y));
            Cursor = Cursors.Default;
            creatingOperator = null;
        }

        #endregion Мышь
    }
}
