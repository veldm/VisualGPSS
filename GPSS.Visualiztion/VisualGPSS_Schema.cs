using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.Visualiztion
{
    public partial class VisualGPSS_Schema
    {
        public List<string> Labels { get; }
        public List<VisualElement> Elements { get; }

        public VisualGPSS_Schema(List<string> labels, List<VisualElement> elements)
        {
            Labels = labels ?? throw new ArgumentNullException(nameof(labels));
            Elements = elements ?? throw new ArgumentNullException(nameof(elements));
        }

        public VisualGPSS_Schema()
        {
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
