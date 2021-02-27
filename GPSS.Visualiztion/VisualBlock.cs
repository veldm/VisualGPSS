using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            width = 170;
            heigth = 85;
            BlockColor = Color.White;
        }

        [JsonConstructor]
        public VisualBlock(int width, int heigth, Color blockColor, Operator essence, uint number,
            Point center, Color _mainColor, Color _linesColor, Font _font, Color _fontColor)
            : base(essence, number, center, _mainColor, _linesColor, _font, _fontColor)
        {
            this.width = width;
            this.heigth = heigth;
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

            brush = new SolidBrush(BlockColor);
            _x = center.X - (width / 2 - 7);
            _y = center.Y - (heigth / 2 - 20);
            lock(graphics)
            {
                graphics.FillRectangle(brush, _x, _y, width - 14, heigth - 27);
            }

            brush = new SolidBrush(FontColor);
            int labelCharsCount = (int)(((width - 6) / Font.SizeInPoints) * 0.7);
            string labelViev = essence.Label;
            if (essence.Label is not null or "")
            {
                labelViev = essence.Label.Length < labelCharsCount ? essence.Label :
                    essence.Label.Substring(0, labelCharsCount - 2) + "...";
            }
            lock(graphics)
            {
                graphics.DrawString(essence.Label is null ? "" : labelViev, Font, brush,
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
                string body = essence.Name;
                foreach (string argument in essence.Arguments)
                    body += $" ,{argument}";
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

                if (essence.Comment is not null or "")
                {
                    bodyString += '\n';
                    lock(graphics)
                    {
                        if (graphics.MeasureString(bodyString, Font).Height + Font.Height > heigth - 27)
                            return bodyString;
                    }
                    foreach (char c in essence.Comment)
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
