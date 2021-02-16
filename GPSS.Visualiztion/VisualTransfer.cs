using System;
using System.Drawing;

namespace GPSS.Visualiztion
{
    public class VisualTransfer : VisualElement
    {
        public GPSS.Block Transfer
        {
            get => (GPSS.Block)essence;
            set => essence = value;
        }

        private VisualBlock startBlock;
        private VisualBlock block1;
        private VisualBlock block2;
        private uint digit;


        public override void Draw(Graphics graphics)
        {
            switch (Transfer.Type)
            {
                case GPSS.Block.BlockType.TRANSFER_UNCON:
                    unconDraw();
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
                Point start = new Point(startBlock.center.X,
                    startBlock.center.Y - startBlock.heigth / 2);
                Point destination = new Point(this.block1.center.X,
                    this.block1.center.Y + this.block1.heigth / 2);
                graphics.DrawLine(new Pen(Color.DarkBlue, 3), start, destination);
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
