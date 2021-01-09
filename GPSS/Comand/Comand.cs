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

        internal ComandType Type { get => type; set => type = value; }

        internal override string GetName()
        {
            return Enum.GetName(typeof(ComandType), type);
        }

        /// <summary>
        /// Переопределение <see cref="Operator.Code"/> для команд со сложной сигнатурой
        /// </summary>
        public override string Code => throw new NotImplementedException();

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
