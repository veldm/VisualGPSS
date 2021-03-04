using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.Visualiztion
{
    class Device : VisualBlock
    {
        public new List<Operator> essence;

        public Device(uint number, Point center, VisualGPSS_Schema parentSchema, string label,
            bool isMultiChannell, string queueName, string Name, double delay, double scatter, int chanellCount = 1) :
            base(null, number, center, parentSchema) 
        {
            essence = new List<Operator>();
            if (isMultiChannell)
            {

            }
            else
            {
                string[] args1 = { queueName };
                string[] args2 = { Name };
                string[] args3 = { delay.ToString(), scatter.ToString() };

                essence.Add(new GPSS.Block(label, args1, null, Block.BlockType.QUEUE));
                essence.Add(new GPSS.Block(null, args2, null, Block.BlockType.SEIZE));
                essence.Add(new GPSS.Block(null, args1, null, Block.BlockType.DEPART));
                essence.Add(new GPSS.Block(null, args3, null, Block.BlockType.ADVANCE));
                essence.Add(new GPSS.Block(null, args2, null, Block.BlockType.RELEASE));
            }
        }

        [JsonConstructor]
        public Device(int width, int heigth, Color blockColor, List<Operator> essence, uint number, Point center,
            Color _mainColor, Color _linesColor, Font _font, Color _fontColor) :
            base(width, heigth, blockColor, null, number, center, _mainColor, _linesColor, _font, _fontColor)
        { this.essence = essence; }
    }
}
