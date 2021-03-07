using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.Visualiztion
{
    public class Device : VisualBlock
    {
        private new List<Operator> essence;
        private string queueName;
        private string name;
        private string label;
        private double delay;
        private double scatter;
        private int chanellCount;

        [Browsable(false)]
        public bool IsMultiChanell => ChanellCount == 1;

        [Browsable(false)] public override string Code
        {
            get
            {
                string result = "";
                for (int i = 0; i < essence.Count - 1; i++)
                    result += $"{essence[i].Code}\n";
                result += essence.Last().Code;
                return result;
            }
        }

        [Browsable(false)] public List<Operator> Essence { get => essence; set => essence = value; }

        [Browsable(false)] public string QueueName { get => queueName; set => queueName = value; }

        #pragma warning disable CS0114 // Член скрывает унаследованный член: отсутствует ключевое слово переопределения
        [Browsable(false)] public string Name { get => name; set => name = value; }

        [Browsable(false)] public string Label { get => label; set => label = value; }
        #pragma warning restore CS0114 // Член скрывает унаследованный член: отсутствует ключевое слово переопределения

        [Browsable(false)] public double Delay { get => delay; set => delay = value; }

        [Browsable(false)] public double Scatter { get => scatter; set => scatter = value; }

        [Browsable(false)] public int ChanellCount { get => chanellCount; set => chanellCount = value; }

        public Device(uint number, Point center, VisualGPSS_Schema parentSchema, string label,
            string _queueName, string _name, double _delay, double _scatter, int _chanellCount = 1) :
            base(null, number, center, parentSchema) 
        {
            Essence = new List<Operator>();
            QueueName = _queueName;
            name = _name;
            this.label = label;
            Delay = _delay;
            Scatter = _scatter;
            ChanellCount = _chanellCount;

            if (IsMultiChanell)
            {

            }
            else
            {
                string[] args1 = { QueueName };
                string[] args2 = { Name };
                string[] args3 = { Delay.ToString(), Scatter.ToString() };

                Essence.Add(new Block(label, args1, null, Block.BlockType.QUEUE));
                Essence.Add(new Block(null, args2, null, Block.BlockType.SEIZE));
                Essence.Add(new Block(null, args1, null, Block.BlockType.DEPART));
                Essence.Add(new Block(null, args3, null, Block.BlockType.ADVANCE));
                Essence.Add(new Block(null, args2, null, Block.BlockType.RELEASE));
            }
        }

        [JsonConstructor]
        public Device(int width, int heigth, Color blockColor, List<Operator> essence, uint number,
            Point center, Color _mainColor, Color _linesColor, Font _font, Color _fontColor,
            string queueName, string name, string label, double delay, double scatter, int chanellCount) :
            base(width, heigth, blockColor, null, number, center,
                _mainColor, _linesColor, _font, _fontColor)
        { 
            this.Essence = essence;
            this.QueueName = queueName;
            this.name = name;
            this.label = label;
            this.Delay = delay;
            this.Scatter = scatter;
            this.ChanellCount = chanellCount;
        }        
    }
}
