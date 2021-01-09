using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public abstract class Operator    
    {
        private string label;
        private string[] arguments;
        string comment;

        public string Label { get => label; set => label = value; }
        public string Name { get => GetName(); }
        public string[] Arguments { get => arguments; set => arguments = value; }
        public string Comment { get => comment; set => comment = value; }

        /// <summary>
        /// Возвращает код, соответствующий оператору
        /// </summary>
        /// <returns></returns>
        public virtual string Code
        {
            get
            {
                string result = $"{Name} {(label == null || label == string.Empty ? string.Empty : label)}";
                for (int i = 0; i < arguments.Length - 1; i++)
                    result += $"{arguments[i]}, ";
                result += comment == null || comment == string.Empty ? "" : $"; {comment}";
                return result;
            }
        }

        /// <summary>
        /// Проверяет корректность и совместимость параметров
        /// </summary>
        /// <returns></returns>
        public abstract bool Validate();

        internal abstract string GetName();
    }
}
