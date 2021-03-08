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
        private List<Operator> essence = new List<Operator>();
        public uint number;
        public Point center;
        private Color mainColor;
        private Color fontColor;
        private Font font;
        private Color linesColor;
        #endregion Поля

        #region Свойства
        [Browsable(false), JsonIgnore]
        public virtual string Code => Essence.Code;

        [Browsable(false), JsonIgnore]
        public virtual string Label => Essence is not null ? Essence.Label : null;

        [Browsable(false), JsonIgnore]
        public virtual string Name => Essence.Name;

        [Browsable(true), DisplayName("Основной цвет"), JsonIgnore]
        public Color MainColor { get => mainColor; set => mainColor = value; }

        [Browsable(true), DisplayName("Цвет шрифта"), JsonIgnore]
        public Color FontColor { get => fontColor; set => fontColor = value; }

        [Browsable(true), DisplayName("Шрифт"), JsonIgnore]
        public Font Font { get => font; set => font = value; }

        [Browsable(true), DisplayName("Цвет линий"), JsonIgnore]
        public Color LinesColor { get => linesColor; set => linesColor = value; }

        [Browsable(false), JsonIgnore]
        public Operator Essence { get => essence[0]; set => essence[0] = value; }
        #endregion Свойства

        protected VisualElement(Operator essence, uint number,
            Point center, VisualGPSS_Schema parentSchema)
        {
            this.essence.Add(essence);
            this.number = number;
            this.center = center;

            mainColor = parentSchema.DefaultElementsColor;
            linesColor = parentSchema.DefaultElementsLinesColor;
            font = parentSchema.DefaultFont;
            fontColor = parentSchema.DefaultFontColor;
        }

        [JsonConstructor]
        protected VisualElement(List<Operator> essence, uint number,
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
