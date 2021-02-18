using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSS;

namespace GPSS.Visualiztion
{
    public abstract class VisualElement
    {
        public Operator essence;
        public uint number;
        public Point center;
        public Color mainColor;
        public Color fontColor;
        public Font font;
        public VisualGPSS_Schema parentSchema;

        public abstract bool IsClicked(Point clickPoint);
        public abstract bool IsVerticalTouching(Point clickPoint);
        public abstract bool IsHorizontalTouching(Point clickPoint);
        public abstract bool IsLeftDiagonalTouching(Point clickPoint);
        public abstract bool IsRightDiagonalTouching(Point clickPoint);
        public abstract void Draw(Graphics graphics);
        public abstract void GetProperties();
    }
}
