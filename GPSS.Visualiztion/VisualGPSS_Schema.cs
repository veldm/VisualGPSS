using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.Visualiztion
{
    public class VisualGPSS_Schema
    {
        private readonly List<string> labels;
        private readonly List<VisualElement> elements;

        public List<string> Labels { get => labels; }
        public List<VisualElement> Elements { get => elements; }

        public void DrawDefaultTransfers(Graphics graphics)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i] is not VisualTransfer && Elements[i + 1] is not VisualTransfer)
                {
                    graphics.DrawLine(new Pen(Color.DarkBlue, 3),
                        Elements[i].center, Elements[i + 1].center);
                }
            }
        }
    }
}
