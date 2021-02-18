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
        private Color mainColor;
        private Color fontColor;
        private Font font;
        public VisualGPSS_Schema parentSchema;
        
        public Color MainColor { get => mainColor; set => mainColor = value; }
        public Color FontColor { get => fontColor; set => fontColor = value; }
        public Font Font { get => font; set => font = value; }

        public abstract bool IsClicked(Point clickPoint);
        public abstract bool IsVerticalTouching(Point clickPoint);
        public abstract bool IsHorizontalTouching(Point clickPoint);
        public abstract bool IsLeftDiagonalTouching(Point clickPoint);
        public abstract bool IsRightDiagonalTouching(Point clickPoint);
        public abstract void Draw(Graphics graphics);
        public abstract void GetProperties();
    }
}
