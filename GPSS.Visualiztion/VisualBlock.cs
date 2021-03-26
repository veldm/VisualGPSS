using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace GPSS.Visualiztion
{
    public class VisualBlock : VisualElement    
    {
        [Browsable(true), DisplayName("Цвет текстового поля")]
        public Color BlockColor { get; set; }

        public VisualBlock(Operator essence, uint number, Point center,
            VisualGPSS_Schema parentSchema) : base(essence, number, center, parentSchema)
        {
            width = 170;
            heigth = 85;
            BlockColor = Color.White;
        }

        [JsonConstructor]
        public VisualBlock(int width, int heigth, Color blockColor, Operator essence, uint number,
            Point center, Color _mainColor, Color _linesColor, Font _font, Color _fontColor)
            : base(essence, number, width, heigth, center, _mainColor, _linesColor, _font, _fontColor)
        {
            BlockColor = blockColor;
        }

        public override void Draw(Graphics graphics, List<VisualElement> otherElements)
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
            lock (graphics)
            {
                graphics.FillRectangle(brush, _x, _y, width, heigth);
            }
            Pen p = new Pen(LinesColor, 3);
            lock (graphics)
            {
                graphics.DrawRectangle(p, _x, _y, width, heigth);
            }

            brush = new SolidBrush(BlockColor);
            _x = center.X - (width / 2 - 7);
            _y = center.Y - (heigth / 2 - 20);
            lock(graphics)
            {
                graphics.FillRectangle(brush, _x, _y, width - 14, heigth - 27);
            }

            brush = new SolidBrush(FontColor);
            int labelCharsCount = (int)(((width - 6) / Font.SizeInPoints) * 0.7);
            string labelViev = Essence.Label;
            if (Essence.Label is not null or "")
            {
                labelViev = Essence.Label.Length < labelCharsCount ? Essence.Label :
                    Essence.Label.Substring(0, labelCharsCount - 2) + "...";
            }
            lock(graphics)
            {
                graphics.DrawString(Essence.Label is null ? "" : labelViev, Font, brush,
                    new Point(center.X - width / 2 + 3, center.Y - heigth / 2 + 3));
            }
            lock(graphics)
            {
                graphics.DrawString((number + 1).ToString(), Font, brush,
                    new Point(center.X + width / 2 - 15, center.Y - heigth / 2 + 3));
            }
            //string[] codeString = essence.Code.Split(';');
            //if (codeString.Length == 2)
            //    graphics.DrawString($"{codeString[0]}\n{codeString[1]}",
            //        Font, brush, _x + 3, _y + 3);
            /*else*/
            string codeString = CodeToDraw();
            lock(graphics)
            {
                graphics.DrawString(codeString, Font, brush, _x + 3, _y + 3);
            }
            GC.Collect();

            string CodeToDraw()
            {
                string body = $"{Essence.Name} ";
                for (int i = Essence.Arguments.Length - 1; !(i < 0); i--)
                {
                    if (Essence.Arguments[i] is not "")
                    {
                        for (int j = 0; !(j > i); j++)
                            body += $"{Essence.Arguments[j]},";
                        break;
                    }
                }
                string bodyString = "";
                foreach (char c in body)
                {
                    bodyString += c;
                    lock(graphics)
                    {
                        if (graphics.MeasureString(bodyString, Font).Width > width - 14)
                            bodyString += '\n';
                        if (graphics.MeasureString(bodyString, Font).Height > heigth - 27)
                            return bodyString;
                    }
                }

                if (Essence.Comment is not null or "")
                {
                    bodyString += '\n';
                    lock(graphics)
                    {
                        if (graphics.MeasureString(bodyString, Font).Height + Font.Height > heigth - 27)
                            return bodyString;
                    }
                    foreach (char c in Essence.Comment)
                    {
                        bodyString += c;
                        lock(graphics)
                        {
                            if (graphics.MeasureString(bodyString, Font).Width > width - 6)
                                bodyString += '\n';
                            if (graphics.MeasureString(bodyString, Font).Height > heigth - 27)
                                return bodyString;
                        }
                    }
                }

                return bodyString;
            }
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
