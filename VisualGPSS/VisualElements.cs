using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSS;

namespace VisualGPSS
{
    abstract class VisualElement
    {
        public Operator essence;
        public abstract bool IsClicked(Point clickPoint);
        public abstract bool IsVerticalTouching(Point clickPoint);
        public abstract bool IsHorizontalTouching(Point clickPoint);
        public abstract bool IsLeftDiagonalTouching(Point clickPoint);
        public abstract bool IsRightDiagonalTouching(Point clickPoint);
        public abstract void Draw(Graphics graphics);
        public abstract void getProperties();
    }

    class VisualBlock : VisualElement    
    {
        public int width;
        public int heigth;
        public Point center;

        public Color mainColor;
        public Color blockColor;

        public Color fontColor;
        public Font font;

        public VisualBlock(int width, int heigth, Point center, Color mainColor,
            Color blockColor, Color fontColor, Font font)
        {
            this.width = width;
            this.heigth = heigth;
            this.center = center;

            this.mainColor = mainColor;
            this.blockColor = blockColor;

            this.fontColor = fontColor;
            this.font = font;
        }

        public override void Draw(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(mainColor);
            //Point[] vertexes =
            //{
            //    new Point(center.X + width / 2, center.Y + heigth / 2),
            //    new Point(center.X + width / 2, center.Y - heigth / 2),
            //    new Point(center.X - width / 2, center.Y + heigth / 2),
            //    new Point(center.X - width / 2, center.Y - heigth / 2)
            //};
            int _x = center.X - width / 2;
            int _y = center.Y - heigth / 2;
            graphics.FillRectangle(brush, _x, _y, width, heigth);

            brush = new SolidBrush(blockColor);
            _x = center.X - (width / 2 - 7);
            _y = center.Y - (heigth / 2 - 20);
            graphics.FillRectangle(brush, _x, _y, width - 14, heigth - 27);

            brush = new SolidBrush(fontColor);
            graphics.DrawString("1111", font, brush, new Point(center.X - width / 2, center.Y - heigth / 2));
        }

        public override void getProperties()
        {
            throw new NotImplementedException();
        }

        public override bool IsClicked(Point clickPoint) => 
            (clickPoint.X > center.X - width / 2 && clickPoint.X < center.X + width / 2)
            && (clickPoint.Y > center.Y - heigth / 2 && clickPoint.Y < center.Y + heigth / 2);

        public override bool IsVerticalTouching(Point clickPoint) =>
            (clickPoint.X == center.X - width / 2 || clickPoint.X == center.X + width / 2)
            && (clickPoint.Y > center.Y - heigth / 2 && clickPoint.Y < center.Y + heigth / 2);

        public override bool IsHorizontalTouching(Point clickPoint) =>
            (clickPoint.X > center.X - width / 2 && clickPoint.X < center.X + width / 2)
            && (clickPoint.Y == center.Y - heigth / 2 || clickPoint.Y == center.Y + heigth / 2);

        public override bool IsLeftDiagonalTouching(Point clickPoint) =>
            (clickPoint.X == center.X - width / 2 && clickPoint.Y == center.Y - heigth / 2)
            || (clickPoint.X == center.X + width / 2 && clickPoint.Y == center.Y + heigth / 2);

        public override bool IsRightDiagonalTouching(Point clickPoint) =>
            (clickPoint.X == center.X + width / 2 && clickPoint.Y == center.Y - heigth / 2)
            || (clickPoint.X == center.X - width / 2 && clickPoint.Y == center.Y + heigth / 2);
    }

    class VisualTransfer : VisualElement
    {
        public GPSS.Block Transfer
        {
            get => (GPSS.Block)essence;
            set => essence = value;
        }

        private VisualBlock startBlock;



        public override void Draw(Graphics graphics)
        {
            switch (Transfer.Type)
            {
                case GPSS.Block.BlockType.TRANSFER_UNCON:
                    //
                    break;
                case GPSS.Block.BlockType.TRANSFER_ALL:
                    //
                    break;
                case GPSS.Block.BlockType.TRANSFER_BOTH:
                    //
                    break;
                case GPSS.Block.BlockType.TRANSFER_PICK:
                    //
                    break;
                case GPSS.Block.BlockType.TRANSFER_VARIABLE:
                    //
                    break;
                default:
                    throw new Exception("Несоответствие типов");
            }

            void unconDraw()
            {
                
            }

            void allDraw()
            {

            }

            void bothDraw()
            {

            }

            void pickDraw()
            {

            }

            void variableDraw()
            {

            }
        }

        public override void getProperties()
        {
            throw new NotImplementedException();
        }

        public override bool IsClicked(Point clickPoint)
        {
            throw new NotImplementedException();
        }

        public override bool IsHorizontalTouching(Point clickPoint) => false;

        public override bool IsLeftDiagonalTouching(Point clickPoint) => false;

        public override bool IsRightDiagonalTouching(Point clickPoint) => false;

        public override bool IsVerticalTouching(Point clickPoint) => false;
    }
}
