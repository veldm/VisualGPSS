using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSS;

namespace GPSS.Visualiztion
{
    public abstract class VisualElement
    {
        #region Поля
        public Operator essence;
        public uint number;
        public Point center;
        private Color mainColor;
        private Color fontColor;
        private Font font;
        private Color linesColor;
        public VisualGPSS_Schema parentSchema;
        #endregion Поля

        #region Свойства
        [Browsable(true), DisplayName("Основной цвет")]
        public Color MainColor { get => mainColor; set => mainColor = value; }

        [Browsable(true), DisplayName("Цвет шрифта")]
        public Color FontColor { get => fontColor; set => fontColor = value; }

        [Browsable(true), DisplayName("Шрифт")]
        public Font Font { get => font; set => font = value; }

        [Browsable(true), DisplayName("Цвет линий")]
        public Color LinesColor { get => linesColor; set => linesColor = value; }
        #endregion Свойства

        protected VisualElement(Operator essence, uint number,
            Point center, VisualGPSS_Schema parentSchema)
        {
            this.essence = essence ?? throw new ArgumentNullException(nameof(essence));
            this.number = number;
            this.center = center;
            this.parentSchema = parentSchema ??
                throw new ArgumentNullException(nameof(parentSchema));

            mainColor = parentSchema.DefaultElementsColor;
            linesColor = parentSchema.DefaultElementsLinesColor;
            font = parentSchema.DefaultFont;
            fontColor = parentSchema.DefaultFontColor;
        }

        #region Абстрактные методы
        public abstract bool IsClicked(Point clickPoint);
        public abstract bool IsVerticalTouching(Point clickPoint);
        public abstract bool IsHorizontalTouching(Point clickPoint);
        public abstract bool IsLeftDiagonalTouching(Point clickPoint);
        public abstract bool IsRightDiagonalTouching(Point clickPoint);
        public abstract void Draw(Graphics graphics);
        public abstract void GetProperties();
        #endregion Абстрактные методы
    }
}
