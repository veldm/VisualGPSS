using System;
using System.ComponentModel;
using System.Drawing;

namespace GPSS.Visualiztion
{
    public class VisualBlock : VisualElement    
    {
        public int width;
        public int heigth;

        [Browsable(true), DisplayName("Цвет текстового поля")]
        public Color BlockColor { get; set; }

        public VisualBlock(Operator essence, uint number, Point center,
            VisualGPSS_Schema parentSchema) : base(essence, number, center, parentSchema)
        {
            width = 135;
            heigth = 80;
            BlockColor = Color.White;
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

            brush = new SolidBrush(BlockColor);
            _x = center.X - (width / 2 - 7);
            _y = center.Y - (heigth / 2 - 20);
            graphics.FillRectangle(brush, _x, _y, width - 14, heigth - 27);

            brush = new SolidBrush(FontColor);
            int labelCharsCount = ((width - 6) / (int)Font.SizeInPoints) / 3;
            string labelViev = essence.Label;
            if (essence.Label is not null or "")
            {
                labelViev = essence.Label.Length < labelCharsCount ? essence.Label :
                    essence.Label.Substring(0, labelCharsCount - 2) + "...";
            }
            graphics.DrawString(essence.Label is null ? "" : labelViev, Font, brush,
                new Point(center.X - width / 2 + 3, center.Y - heigth / 2 + 3));
            graphics.DrawString((number + 1).ToString(), Font, brush,
                new Point(center.X + width / 2 - 15, center.Y - heigth / 2 + 3));            
            graphics.DrawString(essence.Code, Font, brush, _x + 3, _y + 3);
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
