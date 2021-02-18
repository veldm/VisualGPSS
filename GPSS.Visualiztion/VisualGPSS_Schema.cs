using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.Visualiztion
{
    public partial class VisualGPSS_Schema
    {
        private Font font;
        private Color fontColor;
        private Color backgroundColor;

        [Browsable(false)]
        public List<string> Labels { get; }

        [Browsable(false)]
        public List<VisualElement> Elements { get; }

        [Browsable(true), DisplayName("Шрифт")]
        public Font Font { get => font; set => font = value; }

        [Browsable(true), DisplayName("Цвет шрифта")]
        public Color FontColor { get => fontColor; set => fontColor = value; }

        [Browsable(true), DisplayName("Цвет фона")]
        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }

        public VisualGPSS_Schema(Font font, Color fontColor, Color backgroundColor)
        {
            this.Font = font ?? throw new ArgumentNullException(nameof(font));
            this.FontColor = fontColor;
            this.BackgroundColor = backgroundColor;

            Labels = new List<string>();
            Elements = new List<VisualElement>();
        }

        public void Draw(Graphics graphics)
        {
            for (int i = 0; i < Elements.Count - 1; i++)
                if (Elements[i] is not VisualTransfer && Elements[i + 1] is not VisualTransfer)
                    graphics.DrawLine(new Pen(Color.DarkBlue, 3),
                        Elements[i].center, Elements[i + 1].center);

            foreach (VisualElement element in Elements.Where(element =>
                element is VisualTransfer)) element.Draw(graphics);

            foreach (VisualElement element in Elements.Where(element =>
                element is not VisualTransfer)) element.Draw(graphics);
        }
    }
}
