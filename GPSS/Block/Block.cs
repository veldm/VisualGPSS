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

        public new string Name { get => Enum.GetName(typeof(BlockType), type); }

        /// <summary>
        /// Переопределение <see cref="Operator.Code"/> для блоков со сложной сигнатурой
        /// </summary>
        /// <returns></returns>
        public override string Code => throw new NotImplementedException();
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
