using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualGPSS
{
    interface IVisualElement
    {
        bool IsClicked(Point clickPoint);
        void Draw(Graphics graphics);
        void getProperties();
    }

    class VisualBlock : IVisualElement    
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

        public void Draw(Graphics graphics)
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
            graphics.DrawString("", font, brush, new Point(center.X - width / 2, center.Y - heigth / 2));
        }

        public void getProperties()
        {
            throw new NotImplementedException();
        }

        public bool IsClicked(Point clickPoint) => 
            (clickPoint.X > center.X - width / 2 && clickPoint.X < center.X + width / 2)
            && (clickPoint.Y > center.Y - heigth / 2 && clickPoint.Y < center.Y + heigth / 2);
    }
}
