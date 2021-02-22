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
        private readonly Dictionary<string, VisualElement> labels;
        private readonly List<VisualElement> elements;
        private Font defaultFont;
        private Color defaultFontColor;
        private Color backgroundColor;
        private Color defaultElementsColor;
        private Color defaultLinesColor;
        #endregion Поля

        #region Свойства
        [Browsable(false)]
        public Dictionary<string, VisualElement> Labels => labels;

        [Browsable(false)]
        public List<string> LabelsList => Labels.Keys.ToList();

        [Browsable(false)]
        public List<VisualElement> ElementsWithLabelsList => Labels.Values.ToList();

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
            DefaultFont = font ?? throw new ArgumentNullException(nameof(font));
            DefaultFontColor = fontColor;
            BackgroundColor = backgroundColor;

            labels = new Dictionary<string, VisualElement>();
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

        public void AddBlock(uint number, Point center, string type,
            string label, string[] args, string comment)
        {
            Block.BlockType blockType = (Block.BlockType)Enum.Parse(typeof(Block.BlockType), type);
            Block block = new Block(label, args, comment, blockType);

            if (blockType.IsFuncBlock())
            {
                VisualBlock visualBlock = new VisualBlock(block, number, center, this);
                Elements.Insert((int)number, visualBlock);
            }
            else
            {
                throw new ArgumentException(nameof(block));
            }
        }

        public void AddTransfer(string type, VisualBlock startBlock, VisualBlock block1,
            VisualBlock block2, double digit, string label, string[] args, string comment)        
        {
            Block.BlockType blockType = (Block.BlockType)Enum.Parse(typeof(Block.BlockType), type);
            Block block = new Block(label, args, comment, blockType);

            if (blockType.IsTransfer())
            {
                uint number = startBlock.number + 1;
                VisualTransfer visualTransfer = new VisualTransfer(startBlock, block1, block2, digit,
                    block, number, new Point(), this);
                Elements.Insert((int)number, visualTransfer);
            }
            else
            {
                throw new ArgumentException(nameof(block));
            }
        }
        #endregion Методы
    }
}
