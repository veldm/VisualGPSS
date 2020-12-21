using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualGPSS
{
    abstract class VisualElement
    {
        public abstract bool IsClicked(Point clickPoint);
        public abstract void Draw();
        public abstract void getProperties();
    }

    class VisualBlock : VisualElement    
    {
        public int width;
        public int heigth;
        public Point center;

        public Color mainColor;
        public Color blockColor;
        public Color fontColor;

        public Font font;

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void getProperties()
        {
            throw new NotImplementedException();
        }

        public override bool IsClicked(Point clickPoint) => 
            (clickPoint.X > center.X - width / 2 && clickPoint.X < center.X + width / 2)
            && (clickPoint.Y > center.Y - heigth / 2 && clickPoint.Y < center.Y + heigth / 2);
    }
}
