using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.Visualiztion
{
    public class VisualGPSS_Schema
    {
        private List<string> labels;
        private List<VisualElement> elements;

        public List<string> Labels { get => labels; set => labels = value; }
        public List<VisualElement> Elements { get => elements; set => elements = value; }
    }
}
