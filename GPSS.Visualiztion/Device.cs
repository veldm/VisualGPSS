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
        private List<Operator> essence;
        private string queueName;
        private string name;
        private string label;
        private double delay;
        private double scatter;
        private int chanellCount;

        [Browsable(false)]
        public bool IsMultiChanell => ChanellCount > 1;

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

        [Browsable(false), JsonIgnore] public List<Operator> Operators
            { get => essence; set => essence = value; }

        [Browsable(false), JsonIgnore] public string QueueName
        { get => queueName; set => queueName = value; }

        [Browsable(false)]
        public override object[] ExtendedParams => new object[]
            { Operators, QueueName, Delay, Scatter, ChanellCount };

        //#pragma warning disable CS0114
        // Член скрывает унаследованный член: отсутствует ключевое слово переопределения
        [Browsable(false)] public override string Name { get => name; }

        [Browsable(false)] public override string Label { get => label; }
        //#pragma warning restore CS0114
        // Член скрывает унаследованный член: отсутствует ключевое слово переопределения

        [Browsable(false), JsonIgnore] public double Delay { get => delay; set => delay = value; }

        [Browsable(false), JsonIgnore] public double Scatter
            { get => scatter; set => scatter = value; }

        [Browsable(false), JsonIgnore] public int ChanellCount
            { get => chanellCount; set => chanellCount = value; }

        public Device(uint number, Point center, VisualGPSS_Schema parentSchema, string label,
            string _queueName, string _name, double _delay, double _scatter, int _chanellCount = 1) :
            base(null, number, center, parentSchema) 
        {
            width = 170;
            heigth = 170;

            Operators = new List<Operator>();
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

                Operators.Add(new Block(label, args1, null, Block.BlockType.QUEUE));
                Operators.Add(new Block(null, args2, null, Block.BlockType.SEIZE));
                Operators.Add(new Block(null, args1, null, Block.BlockType.DEPART));
                Operators.Add(new Block(null, args3, null, Block.BlockType.ADVANCE));
                Operators.Add(new Block(null, args2, null, Block.BlockType.RELEASE));
            }
        }

        [JsonConstructor]
        public Device(int width, int heigth, Color blockColor, List<Operator> essence, uint number,
            Point center, Color _mainColor, Color _linesColor, Font Font, Color _fontColor,
            string queueName, string Name, string Label, double delay, double scatter,
            int chanellCount, object[] ExtendedParams) :
            base(width, heigth, blockColor, null, number, center,
                _mainColor, _linesColor, Font, _fontColor)
        { 
            this.Operators = (List<Operator>)(essence ?? ExtendedParams[0]);
            this.QueueName = (string)(queueName ?? ExtendedParams[1]);
            this.name = Name;
            this.label = Label;
            this.Delay = (double)ExtendedParams[2];
            this.Scatter = (double)ExtendedParams[3];
            this.ChanellCount = int.Parse(ExtendedParams[4].ToString());
        }

        public override void Draw(Graphics graphics, List<VisualElement> otherElements)
        {
            SolidBrush brush = new SolidBrush(MainColor);
            int _x = center.X - width / 2;
            int _y = center.Y - heigth / 2;
            lock (graphics)
            {
                graphics.FillRectangle(brush, _x, _y, width, heigth);
            }
            Pen p = new Pen(LinesColor, 3);
            lock (graphics)
            {
                graphics.DrawRectangle(p, _x, _y, width, heigth);
            }

            brush = new SolidBrush(BlockColor);
            _x = center.X - (width / 2 - 7);
            _y = center.Y - (heigth / 2 - 40);
            lock (graphics)
            {
                graphics.FillRectangle(brush, _x, _y, width - 14, heigth - 47);
            }

            brush = new SolidBrush(FontColor);
            int labelCharsCount = (int)(((width - 6) / Font.SizeInPoints) * 0.7);
            string labelViev = Label;
            if (Label is not null or "")
            {
                labelViev = Label.Length < labelCharsCount ? Label :
                    Label.Substring(0, labelCharsCount - 2) + "...";
            }
            lock (graphics)
            {
                graphics.DrawString(Label is null ? "" : labelViev, Font, brush,
                    new Point(center.X - width / 2 + 3, center.Y - heigth / 2 + 3));
                graphics.DrawString((number + 1).ToString(), Font, brush,
                    new Point(center.X + width / 2 - 30, center.Y - heigth / 2 + 3));
            }

            brush = new SolidBrush(FontColor);
            int nameCharsCount = (int)(((width - 6) / Font.SizeInPoints) * 0.7);
            string nameViev = Name;
            if (Name is not null or "")
            {
                nameViev = Name.Length < nameCharsCount ? Name :
                    $"{Name.Substring(0, nameCharsCount - 2)}...";
            }
            string threadCount = $"x{(IsMultiChanell ? chanellCount : 1)}";
            lock (graphics)
            {
                graphics.DrawString(Name is null ? "" : nameViev, Font, brush,
                    new Point(center.X - width / 2 + 3, center.Y - heigth / 2 + 6 + Font.Height));
                graphics.DrawString((threadCount).ToString(), Font, brush,
                    new Point(center.X + width / 2 - 30, center.Y - heigth / 2 + 6 + Font.Height));
            }

            for (int i = 0, j = 0; i < Operators.Count; i++, j++)
            {
                string codeString = CodeToDraw(Operators[i], ref j);
                lock (graphics)
                {
                    graphics.DrawString(codeString, Font, brush, _x + 3, _y + 3 + j * Font.Height);
                }
            }

            string CodeToDraw(GPSS.Operator @operator, ref int jj)
            {
                string body = $"{@operator.Name} ";
                for (int i = @operator.Arguments.Length - 1; !(i < 0); i--)
                {
                    if (@operator.Arguments[i] is not "")
                    {
                        for (int j = 0; !(j > i); j++)
                            body += $"{@operator.Arguments[j]},";
                        break;
                    }
                }
                string bodyString = "";
                foreach (char c in body)
                {
                    bodyString += c;
                    lock (graphics)
                    {
                        if (graphics.MeasureString(bodyString, Font).Width > width - 14)
                        {
                            bodyString += '\n';
                            jj++;
                        }
                        if (graphics.MeasureString(bodyString, Font).Height + jj * Font.Height > heigth - 47)
                            return bodyString;
                    }
                }

                if (@operator.Comment is not null or "")
                {
                    bodyString += '\n';
                    jj++;
                    lock (graphics)
                    {
                        if (graphics.MeasureString(bodyString, Font).Height  + (jj + 1) * Font.Height > heigth - 47)
                            return bodyString;
                    }
                    foreach (char c in @operator.Comment)
                    {
                        bodyString += c;
                        lock (graphics)
                        {
                            if (graphics.MeasureString(bodyString, Font).Width > width - 6)
                            {
                                bodyString += '\n';
                                jj++;
                            }
                            if (graphics.MeasureString(bodyString, Font).Height + jj * Font.Height > heigth - 47)
                                return bodyString;
                        }
                    }
                }

                return bodyString;
            }

            Point p1, p2, p3, p4, p5, p6;
            p1 = new Point(center.X - width / 2, center.Y - heigth / 2);
            p2 = new Point(center.X - width / 2 - 20, center.Y - heigth / 2 - 20);            
            p3 = new Point(center.X + width / 2, center.Y - heigth / 2);
            p4 = new Point(center.X + width / 2 - 20, center.Y - heigth / 2 - 20);
            p5 = new Point(center.X - width / 2, center.Y + heigth / 2);
            p6 = new Point(center.X - width / 2 - 20, center.Y + heigth / 2 - 20);
            Color color = Color.FromArgb(MainColor.R - 80, MainColor.G - 80, MainColor.B - 80);
            brush = new SolidBrush(color);
            Point[] points1 = { p1, p3, p4, p2 };
            Point[] points2 = { p1, p5, p6, p2 };

            lock (graphics)
            {
                graphics.FillPolygon(brush, points1);
                graphics.FillPolygon(brush, points2);
                graphics.DrawLine(p, p1, p2);
                graphics.DrawLine(p, p3, p4);
                graphics.DrawLine(p, p5, p6);
                graphics.DrawLine(p, p2, p4);
                graphics.DrawLine(p, p2, p6);
            }

            GC.Collect();
        }
    }
}
