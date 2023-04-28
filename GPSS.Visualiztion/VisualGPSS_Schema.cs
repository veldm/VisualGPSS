using GPSS.PLUS;
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
    public partial class VisualGPSS_Schema
    {
        #region Поля
        private readonly List<VisualElement> elements;
        private readonly List<Function> functions;
        private readonly List<Table> tables;
        private Font defaultFont;
        private Color defaultFontColor;
        private Color backgroundColor;
        private Color defaultElementsColor;
        private Color defaultLinesColor;
        #endregion Поля

        #region Свойства
        [Browsable(false), JsonIgnore]
        public Dictionary<string, VisualElement> Labels
        {
            get
            {
                Dictionary<string, VisualElement> res = new Dictionary<string, VisualElement>();
                foreach (var element in from VisualElement element in Elements
                                        where element.Label is not null or ""
                                        select element)
                    if (element.Label is not "") res.Add(element.Label, element);
                return res;
            }
        }

        [Browsable(false), JsonIgnore]
        public string[] Code => (from VisualElement element in Elements
                                 select element.Code).ToArray();

        [Browsable(false), JsonIgnore]
        public string[] FullCode => (from Table table in Tables select table.Code).Concat
            (from Function function in Functions select function.Code).Concat
            (from VisualElement element in Elements select element.Code).ToArray();

        [Browsable(false), JsonIgnore]
        public List<string> LabelsList => Labels.Keys.ToList();

        [Browsable(false), JsonIgnore]
        public List<VisualElement> ElementsWithLabelsList => Labels.Values.ToList();

        [Browsable(false)]
        public List<VisualElement> Elements => elements;

        public List<T> TypeElements<T>() where T : VisualElement =>
            (from VisualElement element in Elements where element is T select element as T).ToList();

        [Browsable(false), JsonIgnore]
        public List<Device> Devices => TypeElements<Device>();

        [Browsable(false), JsonIgnore]
        public List<VisualBlock> Blocks => TypeElements<VisualBlock>();

        [Browsable(false), JsonIgnore]
        public List<VisualTransfer> Transfers => TypeElements<VisualTransfer>();

        [Browsable(false), JsonIgnore]
        public VisualElement LastAddedElement { get; set; }

        [Browsable(true), DisplayName("Шрифт")]
        public Font DefaultFont
        {
            get => defaultFont;
            set
            {
                if (defaultFont is not null)
                {
                    if (Elements.Count > 35)
                    {
                        Parallel.ForEach(Elements.Where(x => x.Font == defaultFont), new ParallelOptions()
                        { MaxDegreeOfParallelism = Environment.ProcessorCount * 8 },
                                element => { element.Font = value; });
                    }
                    else
                    {
                        foreach (Font font in from VisualElement element in Elements
                                              where element.Font.ToString() == defaultFont.ToString()
                                              select element.Font = value) ;
                    }
                }
                defaultFont = value;
            }
        }

        [Browsable(true), DisplayName("Цвет шрифта")]
        public Color DefaultFontColor
        {
            get => defaultFontColor;
            set
            {
                if (Elements.Count > 35)
                {
                    Parallel.ForEach(Elements.Where(x => x.FontColor == defaultFontColor),
                        new ParallelOptions()
                            { MaxDegreeOfParallelism = Environment.ProcessorCount * 8 },
                                element => { element.FontColor = value; });
                }
                else
                {
                    foreach (Color color in from VisualElement element in Elements
                                          where element.FontColor == defaultFontColor
                                          select element.FontColor = value) ;
                }
                defaultFontColor = value;
            }
        }

        [Browsable(true), DisplayName("Цвет фона")]
        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }

        [Browsable(true), DisplayName("Цвет тела блока по умолчанию")]
        public Color DefaultElementsColor
        {
            get => defaultElementsColor;
            set
            {
                if (Elements.Count > 35)
                {
                    Parallel.ForEach(Elements.Where(x => x.MainColor == defaultElementsColor),
                        new ParallelOptions()
                        { MaxDegreeOfParallelism = Environment.ProcessorCount * 8 },
                                element => { element.MainColor = value; });
                }
                else
                {
                    foreach (Color color in from VisualElement element in Elements
                                            where element.MainColor == defaultElementsColor
                                            select element.MainColor = value) ;
                }
                defaultElementsColor = value;
            }
        }

        [Browsable(true), DisplayName("Цвет линий по умолчанию")]
        public Color DefaultElementsLinesColor
        {
            get => defaultLinesColor;
            set
            {
                if (Elements.Count > 35)
                {
                    Parallel.ForEach(Elements.Where(x => x.LinesColor == defaultLinesColor),
                        new ParallelOptions()
                        { MaxDegreeOfParallelism = Environment.ProcessorCount * 8 },
                                element => { element.LinesColor = value; });
                }
                else
                {
                    foreach (Color color in from VisualElement element in Elements
                                            where element.LinesColor == defaultLinesColor
                                            select element.LinesColor = value) ;
                }
                defaultLinesColor = value;
            }
        }

        [Browsable(true), DisplayName("Пользовательские функции")]
        public List<Function> Functions => functions;

        [Browsable(true), DisplayName("Таблицы статистики")]
        public List<Table> Tables => tables;

        #endregion Свойства

        public VisualGPSS_Schema(Font font, Color fontColor, Color backgroundColor,
            Color defaultElementsColor, Color defaultLinesColor)
        {
            elements = new List<VisualElement>();
            DefaultFont = font ?? throw new ArgumentNullException(nameof(font));
            DefaultFontColor = fontColor;
            BackgroundColor = backgroundColor;
            this.defaultElementsColor = defaultElementsColor;
            this.defaultLinesColor = defaultLinesColor;
            tables = new List<Table>();
            functions = new List<Function>();

            //labels = new Dictionary<string, VisualElement>();
            //labelsList = new List<string>();
        }

        [JsonConstructor]
        public VisualGPSS_Schema(List<VisualElement> Elements, Font DefaultFont,
            Color defaultFontColor, Color backgroundColor, Color defaultElementsColor,
            Color defaultLinesColor, List<Table> tables, List<Function> functions)
        {
            //this.labels = labels;
            //this.labelsList = labelsList;
            this.elements = Elements ?? throw new ArgumentNullException(nameof(Elements));
            this.defaultFont = DefaultFont ?? throw new ArgumentNullException(nameof(DefaultFont));
            this.defaultFontColor = defaultFontColor;
            this.backgroundColor = backgroundColor;
            this.defaultElementsColor = defaultElementsColor;
            this.defaultLinesColor = defaultLinesColor;
            this.tables = tables;
            this.functions = functions;
            foreach (VisualElement element in Elements)
            {
                if (element is VisualTransfer transfer)
                {
                    transfer.StartBlock = transfer.StartBlock is not null ?
                        Elements[(int)transfer.StartBlock.number] :
                        Elements[(int)transfer.StartBlockNumber];

                    transfer.Block1 = Elements[(int)transfer.Block1.number];
                    if (transfer.Block2 is not null)
                        transfer.Block2 = Elements[(int)transfer.Block2.number];
                }
            }
        }



        #region Методы
        public void Draw(Graphics graphics)
        {
            foreach (VisualElement element in elements.Where(a => a.center.X < 0 || a.center.Y < 0))
            {
                if (element.center.X < 0)
                    element.center.X = 0;
                if (element.center.Y < 0)
                    element.center.Y = 0;
            }

            ////Parallel.Invoke
            ////(
            /*() => */
            Parallel.For(0, Elements.Count - 1, (i) =>
            {
                if (Elements[i] is not VisualTransfer && Elements[i + 1] is not VisualTransfer)
                   lock (graphics)
                    {
                        graphics.DrawArrowMid(new Pen(DefaultElementsLinesColor, 3),
                            DefaultElementsColor, Elements[i].center, Elements[i + 1].center);
                    }
            });//,

            //    /*() => */
            Parallel.For(0, Elements.Count, (i) =>
              {
                  if (Elements[i] is VisualTransfer)
                      Elements[i].Draw(graphics, this.Elements);
              });
            ////);

            //for (int i = 0; i < Elements.Count - 1; i++)
            //{
            //    if (Elements[i] is not VisualTransfer && Elements[i + 1] is not VisualTransfer)
            //        graphics.DrawArrowMid(new Pen(DefaultElementsLinesColor, 3),
            //            DefaultElementsColor, Elements[i].center, Elements[i + 1].center);
            //}

            //foreach (VisualElement element in Elements.Where(element =>
            //        element is VisualTransfer)) element.Draw(graphics, this.Elements);

            //foreach (VisualElement element in Elements.Where(element =>
            //    element is not VisualTransfer)) element.Draw(graphics, this.Elements);

            Parallel.For(0, Elements.Count, (i) =>
            {
                if (Elements[i] is not VisualTransfer)
                    Elements[i].Draw(graphics, this.Elements);
                GC.Collect();
            });
        }

        public VisualBlock AddBlock(uint number, Point center, string type,
            string label, string[] args, string comment)
        {
            Block.BlockType blockType = (Block.BlockType)Enum.Parse(typeof(Block.BlockType), type);
            Block block = new Block(label, args, comment, blockType);

            if (blockType.IsFuncBlock())
            {
                VisualBlock visualBlock = new VisualBlock(block, number, center, this);
                Elements.Insert((int)number, visualBlock);
                //if (block.Label is not null or "")
                //{
                //    Labels.Add(block.Label, visualBlock);
                //    LabelsList.Add(block.Label);
                //}
                Refresh();
                return visualBlock;
            }
            else
            {
                throw new ArgumentException(nameof(block));
            }
        }

        public VisualTransfer AddTransfer(string type, VisualElement startBlock, VisualElement block1,
            VisualElement block2, double digit, string label, string[] args, string comment,
            bool needRefresh = true)        
        {
            Block.BlockType blockType = (Block.BlockType)Enum.Parse(typeof(Block.BlockType), type);
            Block block = new Block(label, args, comment, blockType);

            if (blockType.IsTransfer())
            {
                uint number = startBlock is not null ? startBlock.number + 1 : (uint)Elements.Count;
                VisualTransfer visualTransfer = new VisualTransfer(startBlock, block1, block2, digit,
                    block, number, new Point(), this);
                Elements.Insert((int)number, visualTransfer);
                
                if (startBlock is not null && needRefresh) Refresh();

                return visualTransfer;
            }
            else
            {
                throw new ArgumentException(nameof(block));
            }
        }

        public Device AddDevice(uint number, Point center, VisualGPSS_Schema schema, string label, 
            string queue, string name, string delay, string scatter,
            int chanellCount = 1, int transactCount = 1)
        {
            Device device = new Device(number, center, schema, label, queue,
                name, delay, scatter, chanellCount, transactCount);
            schema.Elements.Insert((int)number, device);
            Refresh();
            return device;
        }

        public void AddFunction(string name, string operand1, string operand2,
            List<KeyValuePair<string, string>> values)
        {
            Function function = new Function(name, operand1, operand2, values);
            foreach (Function func in Functions)
            {
                if (func.Name == function.Name)
                {
                    throw new ArgumentException("Функция с таким именем уже существует");
                }
            }
            Functions.Add(function);
        }

        public void AddTable(string name, string intervalMax, string intervalWidth,
            string intervalsCount, string timeInterval_RT = null)
        {
            Table table = new Table(name, intervalMax, intervalWidth, intervalsCount, timeInterval_RT);
            foreach (Table tab in Tables)
            {
                if (tab.Name == tab.Name)
                {
                    throw new ArgumentException("Таблица с таким именем уже существует");
                }
            }
            Tables.Add(table);
        }

        public void Refresh()
        {
            Elements.Sort(new Comparison<VisualElement>((e1, e2)
                => e1.number.CompareTo(e2.number)));

            foreach (VisualTransfer transfer in Transfers.Where
                (t => t.StartBlock is not VisualTransfer))
            {
                int index1 = Elements.IndexOf(transfer);
                int index2 = Elements.IndexOf(transfer.StartBlock);
                if (index2 != index1 - 1)
                {
                    VisualElement buf = transfer;
                    Elements.Remove(transfer);
                    index2 = Elements.IndexOf(transfer.StartBlock);
                    Elements.Insert(index2 + 1, buf);
                }
            }

            bool changed;
            do
            {
                changed = false;
                foreach (VisualTransfer transfer in Transfers.Where
                    (t => t.Block1 is VisualTransfer || t.Block2 is VisualTransfer))
                {
                    if (transfer.Block1 is VisualTransfer)
                    {
                        if (Elements.IndexOf(transfer.Block1) != Elements.IndexOf(transfer) + 1)
                        {
                            VisualElement buf = transfer.Block1;
                            Elements.Remove(transfer.Block1);
                            Elements.Insert(Elements.IndexOf(transfer) + 1, buf);
                            changed = true;
                        }
                    }
                    if (transfer.Block2 is VisualTransfer)
                    {
                        int seed = transfer.Block1 is VisualTransfer ? 2 : 1;
                        if (Elements.IndexOf(transfer.Block2) != Elements.IndexOf(transfer) + seed)
                        {
                            VisualElement buf = transfer.Block2;
                            Elements.Remove(transfer.Block2);
                            Elements.Insert(Elements.IndexOf(transfer) + seed, buf);
                            changed = true;
                        }
                    }
                }
            }
            while (!changed);

            //List<VisualTransfer> elems = (from VisualElement elem in Elements
            //                              where elem is VisualTransfer
            //                              select (VisualTransfer)elem).ToList();

            //for (int i = 0; i < elems.Count(); i++)
            //{
            //    int index1 = Elements.IndexOf(elems[i]);
            //    int index2 = Elements.IndexOf(((VisualTransfer)elems[i]).StartBlock);
            //    if (index2 != index1 - 1)
            //    {
            //        VisualElement buf = elems[i];
            //        Elements.Remove(elems[i]);
            //        Elements.Insert(index2 + 1, buf);
            //    }
            //}

            for (int i = 0; i < Elements.Count; i++)
                Elements[i].number = (uint)i;

            //foreach (VisualElement element in elements.Where(a => a.center.X < 0 || a.center.Y < 0))
            //{
            //    if (element.center.X < 0)
            //        element.center.X = 0;
            //    if (element.center.Y < 0)
            //        element.center.Y = 0;
            //}
        }

        public void Remove(VisualElement visualElement)
        {
            Elements.Remove(visualElement);
            //if (visualElement.Label is not null or "")
            //    Labels.Remove(visualElement.Label);
            foreach (VisualTransfer transfer in Transfers)
            {
                if (transfer.StartBlock == visualElement || transfer.Block1 == visualElement ||
                    transfer.Block2 == visualElement)
                {
                    Remove(transfer);
                }
            }
            Refresh();
        }
        #endregion Методы

        public static VisualGPSS_Schema getDefaultSchema(Font font, Color fontColor,
            Color backgroundColor, Color defaultElementsColor, Color defaultLinesColor)
        {
            VisualGPSS_Schema schema = new VisualGPSS_Schema(font, fontColor, backgroundColor,
                defaultElementsColor, defaultLinesColor);

            string[] args = { "10.0", "1.0" };            
            schema.AddBlock(0, new Point(100, 50), "GENERATE", null, args, "Transactions creating");
            args = new string[] { "1" };
            schema.AddBlock(1, new Point(100, 250), "TERMINATE", null, args, "Transactions terminating");

            return schema;
        }
    }
}
