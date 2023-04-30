using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public partial class Block : Operator
    {
        private BlockType type;

        #region Свойства
        public BlockType Type { get => type; set => type = value; }

        /// <summary>
        /// Переопределение <see cref="Operator.Code"/> для блоков со сложной сигнатурой
        /// </summary>
        /// <returns></returns>
        public override string Code
        {
            get
            {
                string cLabel = Label is null or "" ? string.Empty : $"{Label} ";
                return type switch
                {
                    BlockType.TRANSFER_UNCON => $"{cLabel}TRANSFER ,{Arguments[0]}",
                    BlockType.TRANSFER_VARIABLE => $"{cLabel}TRANSFER " +
                        $".{Arguments[0].Substring(2)},{Arguments[1]},{Arguments[2]}",
                    BlockType.SaveValue => $"{cLabel}SaveValue {Arguments[0]}" +
                        $"{(Arguments[1] is "+" or "-" ? Arguments[1] : "")}," +
                        $"{(Arguments.Length is 3 ? Arguments[2] : "")}",
                    _ => base.Code
                };
            }
        }
        #endregion

        public Block(string label, string[] arguments, string comment, BlockType type)
            : base (label, arguments, comment) { this.type = type; }

        #region Методы
        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        internal override string GetName()
        {
            return Enum.GetName(typeof(BlockType), type);
        }
        #endregion Методы
    }
}
