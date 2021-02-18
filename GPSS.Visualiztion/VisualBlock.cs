using System;
using System.Drawing;

namespace GPSS.Visualiztion
{
    public class VisualBlock : VisualElement    
    {
        public int width;
        public int heigth;

        public Color blockColor;

        public VisualBlock(int width, int heigth, Point center, Color mainColor,
            Color blockColor, Color fontColor, Font font)
        {
            this.width = width;
            this.heigth = heigth;
            this.center = center;

            this.MainColor = mainColor;
            this.blockColor = blockColor;

            this.FontColor = fontColor;
            this.Font = font;
        }

        public override void Draw(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(MainColor);
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

            brush = new SolidBrush(FontColor);
            graphics.DrawString(/*essence.Label is null ? "" : essence.Label*/"1111", Font, brush, new Point(center.X - width / 2 + 3, center.Y - heigth / 2 + 3));
        }

        public override void GetProperties()
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
