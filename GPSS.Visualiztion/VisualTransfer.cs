using System;
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
            get => (Block)essence;
            set => essence = value;
        }
        public VisualBlock StartBlock => startBlock;        

        public VisualTransfer(VisualBlock startBlock, VisualBlock block1, VisualBlock block2,
            double digit, Operator essence, uint number, Point center,
            VisualGPSS_Schema parentSchema) : base(essence, number, center, parentSchema)
        {
            this.startBlock = startBlock ?? throw new ArgumentNullException(nameof(startBlock));
            this.block1 = block1 ?? throw new ArgumentNullException(nameof(block1));
            this.block2 = block2 ?? throw new ArgumentNullException(nameof(block2));
            this.digit = digit;
        }

        public override void Draw(Graphics graphics)
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
                Point start = new Point(StartBlock.center.X,
                    StartBlock.center.Y - StartBlock.heigth / 2);
                Point destination = new Point(block1.center.X,
                    block1.center.Y + block1.heigth / 2);
                graphics.DrawLine(new Pen(Color.DarkBlue, 3), start, destination);
            }

            void allDraw()
            {
                (Point pivot1, Point pivot2) = bothDraw();
                Pen pen = new Pen(Color.DarkBlue, 3);
                for (int i = (int)block1.number + (int)digit; i <= block2.number; i += (int)digit)
                {
                    Point point = new Point(center.Y, parentSchema.Elements[i].center.X);
                    graphics.DrawLine(pen, pivot1, point);
                }
            }

            (Point pivot1, Point pivot2) bothDraw()
            {
                int cY = StartBlock.center.Y + (Math.Min(block1.center.Y, block2.center.Y)
                    - StartBlock.center.Y) / 2;
                int cX = StartBlock.center.X;
                center = new Point(cX, cY);

                Point pivot1 = new Point(block1.center.X, center.Y);
                Point pivot2 = new Point(block1.center.X, center.Y);

                Pen pen = new Pen(Color.DarkBlue, 3);
                graphics.DrawLine(pen, StartBlock.center, center);
                graphics.DrawLine(pen, center, pivot1);
                graphics.DrawLine(pen, center, pivot2);
                graphics.DrawLine(pen, pivot1, block1.center);
                graphics.DrawLine(pen, pivot2, block2.center);

                Point rp1 = new Point(center.X + 60, center.Y);
                Point rp2 = new Point(center.X - 60, center.Y);
                Point rp3 = new Point(center.X, center.Y + 30);
                Point rp4 = new Point(center.X, center.Y - 30);
                Point[] points = { rp1, rp2, rp3, rp4 };
                Brush brush = new SolidBrush(Color.SandyBrown);
                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);

                return (pivot1, pivot2);
            }

            void pickDraw()
            {
                (Point pivot1, Point pivot2) = bothDraw();
                Pen pen = new Pen(Color.DarkBlue, 3);
                for (int i = (int)block1.number + 1; i <= block2.number; i++)
                {
                    Point point = new Point(center.Y, parentSchema.Elements[i].center.X);
                    graphics.DrawLine(pen, pivot1, point);
                }
            }

            void variableDraw()
            {
                (Point pivot1, Point pivot2) = bothDraw();
                double v1 = digit;
                double v2 = 1 - v1;
                Brush brush = new SolidBrush(Color.DarkBlue);
                graphics.DrawString(v1.ToString(), Font, brush, x: pivot1.X, y: pivot1.Y - 15);
                graphics.DrawString(v2.ToString(), Font, brush, x: pivot2.X, y: pivot2.Y - 15);
            }
        }

        public override void GetProperties()
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
