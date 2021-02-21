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
        #region Поля
        private readonly List<string> labels;
        private readonly List<VisualElement> elements;
        private Font defaultFont;
        private Color defaultFontColor;
        private Color backgroundColor;
        private Color defaultElementsColor;
        private Color defaultLinesColor;
        #endregion Поля

        #region Свойства
        [Browsable(false)]
        public List<string> Labels => labels;

        [Browsable(false)]
        public List<VisualElement> Elements => elements;

        [Browsable(true), DisplayName("Шрифт")]
        public Font DefaultFont { get => defaultFont; set => defaultFont = value; }

        [Browsable(true), DisplayName("Цвет шрифта")]
        public Color DefaultFontColor { get => defaultFontColor; set => defaultFontColor = value; }

        [Browsable(true), DisplayName("Цвет фона")]
        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }

        [Browsable(true), DisplayName("Цвет тела блока по умолчанию")]
        public Color DefaultElementsColor
        { get => defaultElementsColor; set => defaultElementsColor = value; }

        [Browsable(true), DisplayName("Цвет линий по умолчанию")]
        public Color DefaultElementsLinesColor
        { get => defaultLinesColor; set => defaultLinesColor = value; }
        #endregion Свойства
        
        public VisualGPSS_Schema(Font font, Color fontColor, Color backgroundColor)
        {
            this.DefaultFont = font ?? throw new ArgumentNullException(nameof(font));
            this.DefaultFontColor = fontColor;
            this.BackgroundColor = backgroundColor;

            labels = new List<string>();
            elements = new List<VisualElement>();
        }

        #region Методы
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

        public void AddBlock(int number, string type, string label, string[] args, string comment)
        {
            Block.BlockType blockType = (Block.BlockType)Enum.Parse(typeof(Block.BlockType), type);
            Block block = new Block(label, args, comment, blockType);

            if (blockType.IsFuncBlock())
            {

            }
            else
            {

            }
        }
        #endregion Методы
    }
}
