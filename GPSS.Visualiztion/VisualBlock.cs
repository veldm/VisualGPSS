using System;
using System.Drawing;

namespace GPSS.Visualiztion
{
    public class VisualBlock : VisualElement    
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
}
