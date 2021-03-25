using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public partial class Comand : Operator
    {
        private ComandType type;

        public Comand(string label, string[] arguments, string comment, ComandType type)
            : base(label, arguments, comment) { this.type = type; }

        #region Свойства
        public ComandType Type { get => type; set => type = value; }

        internal override string GetName()
        {
            return Enum.GetName(typeof(ComandType), type);
        }

        /// <summary>
        /// Переопределение <see cref="Operator.Code"/> для команд со сложной сигнатурой
        /// </summary>
        public override string Code
        {
            get
            {
                if (type is ComandType.STORAGE or ComandType.EQU)
                    return $"{Arguments[0]} {Name} {Arguments[1]}";
                return base.Code;
            }
        }
        #endregion Свойства

        #region Методы
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
        #endregion Методы
    }
}
