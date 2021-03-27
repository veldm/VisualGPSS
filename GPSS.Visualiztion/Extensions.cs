using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.Visualiztion
{
    static class Extensions
    {
        public static void DrawArrowNear(this Graphics graphics, Pen pen,
            Color bodyColor, Point start, Point destination)
        {
            double ugol;
            ugol = Math.Atan2(start.X - destination.X, start.Y - destination.Y);
            float x_middle = (destination.X + start.X) / 2;
            float y_middle = (destination.Y + start.Y) / 2;

            float x = x_middle;
            float y = y_middle;

            x_middle = (x_middle + start.X) / 2;
            y_middle = (y_middle + start.Y) / 2;
            x_middle = (x_middle + x) / 2;
            y_middle = (y_middle + y) / 2;

            int x1 = Convert.ToInt32(x_middle + 30 * Math.Sin(0.5 + ugol));
            int y1 = Convert.ToInt32(y_middle + 30 * Math.Cos(0.5 + ugol));
            int x2 = Convert.ToInt32(x_middle + 30 * Math.Sin(ugol - 0.5));
            int y2 = Convert.ToInt32(y_middle + 30 * Math.Cos(ugol - 0.5));

            PointF[] points = { new PointF(x_middle, y_middle),
                new PointF(x1, y1), new PointF(x2, y2) };

            using (Brush brush = new SolidBrush(bodyColor))
            {
                graphics.DrawLine(pen, start, destination);
                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }
        }

        public static void DrawArrowNear(this Graphics graphics, Pen pen, Font font,
            Color fontColor, int number, Color bodyColor, Point start, Point destination)
        {
            double ugol;
            ugol = Math.Atan2(start.X - destination.X, start.Y - destination.Y);
            float x_middle = (start.X + start.X) / 2;
            float y_middle = (start.Y + start.Y) / 2;

            float x = x_middle;
            float y = y_middle;

            x_middle = (x_middle + start.X) / 2;
            y_middle = (y_middle + start.Y) / 2;
            x_middle = (x_middle + x) / 2;
            y_middle = (y_middle + y) / 2;

            int x1 = Convert.ToInt32(x_middle + 30 * Math.Sin(0.5 + ugol));
            int y1 = Convert.ToInt32(y_middle + 30 * Math.Cos(0.5 + ugol));
            int x2 = Convert.ToInt32(x_middle + 30 * Math.Sin(ugol - 0.5));
            int y2 = Convert.ToInt32(y_middle + 30 * Math.Cos(ugol - 0.5));

            PointF[] points = { new PointF(x_middle, y_middle),
                new PointF(x1, y1), new PointF(x2, y2) };

            using (Brush brush = new SolidBrush(bodyColor))
            {
                graphics.DrawLine(pen, start, destination);
                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }

            float x3 = (x1 + x2 + x_middle - 15) / 3;
            float y3 = (y1 + y2 + y_middle - 15) / 3;
            graphics.DrawString(number.ToString(), font, new SolidBrush(fontColor),
                x3 /*- (graphics.MeasureString(number.ToString(), font).Width / 2)*/, y3);
        }

        public static void DrawArrowMid(this Graphics graphics, Pen pen,
            Color bodyColor, Point start, Point destination)
        {
            double ugol;
            ugol = Math.Atan2(start.X - destination.X, start.Y - destination.Y);
            float x_middle = (destination.X + start.X) / 2;
            float y_middle = (destination.Y + start.Y) / 2;

            float x = x_middle;
            float y = y_middle;

            x_middle = (x_middle + destination.X) / 2;
            y_middle = (y_middle + destination.Y) / 2;
            x_middle = (x_middle + x) / 2;
            y_middle = (y_middle + y) / 2;

            int x1 = Convert.ToInt32(x_middle + 30 * Math.Sin(0.5 + ugol));
            int y1 = Convert.ToInt32(y_middle + 30 * Math.Cos(0.5 + ugol));
            int x2 = Convert.ToInt32(x_middle + 30 * Math.Sin(ugol - 0.5));
            int y2 = Convert.ToInt32(y_middle + 30 * Math.Cos(ugol - 0.5));

            PointF[] points = { new PointF(x_middle, y_middle),
                new PointF(x1, y1), new PointF(x2, y2) };

            using (Brush brush = new SolidBrush(bodyColor))
            {
                graphics.DrawLine(pen, start, destination);
                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }
        }

        public static void DrawArrowMid(this Graphics graphics, Pen pen, Font font,
            Color fontColor, int number, Color bodyColor, Point start, Point destination)
        {
            double ugol;
            ugol = Math.Atan2(start.X - destination.X, start.Y - destination.Y);
            float x_middle = (destination.X + start.X) / 2;
            float y_middle = (destination.Y + start.Y) / 2;

            float x = x_middle;
            float y = y_middle;

            x_middle = (x_middle + destination.X) / 2;
            y_middle = (y_middle + destination.Y) / 2;
            x_middle = (x_middle + x) / 2;
            y_middle = (y_middle + y) / 2;

            int x1 = Convert.ToInt32(x_middle + 30 * Math.Sin(0.5 + ugol));
            int y1 = Convert.ToInt32(y_middle + 30 * Math.Cos(0.5 + ugol));
            int x2 = Convert.ToInt32(x_middle + 30 * Math.Sin(ugol - 0.5));
            int y2 = Convert.ToInt32(y_middle + 30 * Math.Cos(ugol - 0.5));

            PointF[] points = { new PointF(x_middle, y_middle),
                new PointF(x1, y1), new PointF(x2, y2) };

            using (Brush brush = new SolidBrush(bodyColor))
            {
                graphics.DrawLine(pen, start, destination);
                graphics.FillPolygon(brush, points);
                graphics.DrawPolygon(pen, points);
            }

            float x3 = (x1 + x2 + x_middle - 15) / 3;
            float y3 = (y1 + y2 + y_middle - 15) / 3;
            graphics.DrawString(number.ToString(), font, new SolidBrush(fontColor),
                x3 /*- (graphics.MeasureString(number.ToString(), font).Width / 2)*/, y3);
        }

        public static bool IsInPolygon(this Point point, Point[] polygonPoints)
        {
            bool result = false;

            if (polygonPoints.Length < 3) return result;

            Point oldPoint = new(polygonPoints.Last().X, polygonPoints.Last().Y);

            for (int i = 0; i < polygonPoints.Length; i++)
            {
                Point newPoint = new(polygonPoints[i].X, polygonPoints[i].Y), p1, p2;

                if (newPoint.X <= oldPoint.X)
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }
                else
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }

                if ((newPoint.X < point.X) == (point.X <= oldPoint.X)
                    && (point.Y - p1.Y) * (p2.X - p1.X) < (p2.Y - p1.Y) * (point.X - p1.X))
                        result = !result;

                oldPoint = newPoint;
            }

            return result;
        }
    }
}
