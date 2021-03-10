using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GPSS.Visualiztion
{
    public class VisualTransfer : VisualElement
    {
        private VisualBlock block1;
        private VisualBlock block2;
        private double digit;
        private readonly VisualBlock startBlock;

        public Block Transfer
        {
            get => (Block)Essence;
            set => Essence = value;
        }
        public VisualBlock StartBlock => startBlock;

        public VisualBlock Block1 { get => block1; set => block1 = value; }
        public VisualBlock Block2 { get => block2; set => block2 = value; }
        public double Digit { get => digit; set => digit = value; }

        public override object[] ExtendedParams
        { get => new object[] { startBlock, block1, block2 }; }

        public VisualTransfer(VisualBlock startBlock, VisualBlock block1, VisualBlock block2,
            double digit, Operator essence, uint number, Point center,
            VisualGPSS_Schema parentSchema) : base(essence, number, center, parentSchema)
        {
            this.startBlock = startBlock ?? throw new ArgumentNullException(nameof(startBlock));
            this.Block1 = block1 ?? throw new ArgumentNullException(nameof(block1));
            this.Block2 = block2 /*?? throw new ArgumentNullException(nameof(block2))*/;
            this.Digit = digit;
        }

        [JsonConstructor]
        public VisualTransfer(VisualBlock block1, VisualBlock block2, double digit,
            VisualBlock startBlock, Operator essence, uint number, object[] ExtendedParams,
            Point center, Color _mainColor, Color _linesColor, Font _font, Color _fontColor)
            : base(essence, number, center, _mainColor, _linesColor, _font, _fontColor)
        {
            this.block1 = (VisualBlock)(block1 ?? ExtendedParams[1]);
            this.block2 = (VisualBlock)(block2 ?? ExtendedParams[2]);
            this.digit = digit;
            this.startBlock = (VisualBlock)(startBlock ?? ExtendedParams[0]);
        }

        public override void Draw(Graphics graphics, List<VisualElement> otherElements)
        {
            switch (Transfer.Type)
            {
                case GPSS.Block.BlockType.TRANSFER_UNCON:
                    unconDraw();
                    break;
                case GPSS.Block.BlockType.TRANSFER_ALL:
                    allDraw();
                    break;
                case GPSS.Block.BlockType.TRANSFER_BOTH:
                    bothDraw();
                    break;
                case GPSS.Block.BlockType.TRANSFER_PICK:
                    pickDraw();
                    break;
                case GPSS.Block.BlockType.TRANSFER_VARIABLE:
                    variableDraw();
                    break;
                default:
                    throw new Exception("Несоответствие типов");
            }

            void unconDraw()
            {
                //Point start = new Point(StartBlock.center.X,
                //    StartBlock.center.Y - StartBlock.heigth / 2);
                //Point destination = new Point(Block1.center.X,
                //    Block1.center.Y + Block1.heigth / 2);
                lock(graphics)
                {
                    graphics.DrawLine(new Pen(Color.DarkBlue, 3), startBlock.center, block1.center);
                }
            }

            void allDraw()
            {
                (Point pivot1, Point pivot2) = bothDraw();
                Pen pen = new Pen(Color.DarkBlue, 3);
                for (int i = (int)Block1.number + (int)Digit; i <= Block2.number; i += (int)Digit)
                {
                    Point point = new Point(center.Y, otherElements[i].center.X);
                    lock(graphics)
                    {
                        graphics.DrawLine(pen, pivot1, point);
                    }
                }
            }

            (Point pivot1, Point pivot2) bothDraw()
            {
                int cY = StartBlock.center.Y + (Math.Min(Block1.center.Y, Block2.center.Y)
                    - StartBlock.center.Y) / 2;
                int cX = StartBlock.center.X;
                center = new Point(cX, cY);

                Point pivot1 = new Point(Block1.center.X, center.Y);
                Point pivot2 = new Point(Block2.center.X, center.Y);

                Pen pen = new Pen(Color.DarkBlue, 3);
                lock(graphics)
                {
                    graphics.DrawLine(pen, StartBlock.center, center);
                    graphics.DrawLine(pen, center, pivot1);
                    graphics.DrawLine(pen, center, pivot2);
                    graphics.DrawLine(pen, pivot1, Block1.center);
                    graphics.DrawLine(pen, pivot2, Block2.center);
                }

                Point rp1 = new Point(center.X - 60, center.Y);
                Point rp2 = new Point(center.X, center.Y + 30);
                Point rp3 = new Point(center.X + 60, center.Y);
                Point rp4 = new Point(center.X, center.Y - 30);
                Point[] points = { rp1, rp2, rp3, rp4 };
                Brush brush = new SolidBrush(Color.SandyBrown);
                lock(graphics)
                {
                    graphics.FillPolygon(brush, points);
                    graphics.DrawPolygon(pen, points);
                }

                return (pivot1, pivot2);
            }

            void pickDraw()
            {
                (Point pivot1, Point pivot2) = bothDraw();
                Pen pen = new Pen(Color.DarkBlue, 3);
                for (int i = (int)Block1.number + 1; i <= Block2.number; i++)
                {
                    Point point = new Point(center.Y, otherElements[i].center.X);
                    lock(graphics)
                    {
                        graphics.DrawLine(pen, pivot1, point);
                    }
                }
            }

            void variableDraw()
            {
                (Point pivot1, Point pivot2) = bothDraw();
                double v1 = Digit;
                double v2 = 1 - v1;
                Brush brush = new SolidBrush(Color.DarkBlue);
                lock(graphics)
                {
                    graphics.DrawString(v1.ToString(), Font, brush, x: pivot1.X, y: pivot1.Y - 15);
                    graphics.DrawString(v2.ToString(), Font, brush, x: pivot2.X, y: pivot2.Y - 15);
                }
            }
        }

        public override void GetProperties()
        {
            throw new NotImplementedException();
        }

        public override bool IsClicked(Point clickPoint)
        {
            return false;
        }

        public override bool IsHorizontalTouching(Point clickPoint) => false;

        public override bool IsLeftDiagonalTouching(Point clickPoint) => false;

        public override bool IsRightDiagonalTouching(Point clickPoint) => false;

        public override bool IsVerticalTouching(Point clickPoint) => false;
    }
}
