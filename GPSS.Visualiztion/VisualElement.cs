using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSS;
using Newtonsoft.Json;

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

            mainColor = parentSchema.DefaultElementsColor;
            linesColor = parentSchema.DefaultElementsLinesColor;
            font = parentSchema.DefaultFont;
            fontColor = parentSchema.DefaultFontColor;
        }

        [JsonConstructor]
        protected VisualElement(Operator essence, uint number,
            Point center, Color _mainColor, Color _linesColor, Font _font, Color _fontColor)
        {
            this.essence = essence ?? throw new ArgumentNullException(nameof(essence));
            this.number = number;
            this.center = center;

            mainColor = _mainColor;
            linesColor = _linesColor;
            font = _font;
            fontColor = _fontColor;
        }

        #region Абстрактные методы
        public abstract bool IsClicked(Point clickPoint);
        public abstract bool IsVerticalTouching(Point clickPoint);
        public abstract bool IsHorizontalTouching(Point clickPoint);
        public abstract bool IsLeftDiagonalTouching(Point clickPoint);
        public abstract bool IsRightDiagonalTouching(Point clickPoint);
        public abstract void Draw(Graphics graphics, List<VisualElement> otherElements);
        public abstract void GetProperties();
        #endregion Абстрактные методы
    }
}
