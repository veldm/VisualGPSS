using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public abstract class Operator    
    {
        #region Поля
        private string label;
        private string[] arguments;
        string comment;
        #endregion

        #region Свойства
        /// <summary>
        /// Метка, соответствующая оператору
        /// </summary>
        public string Label { get => label; set => label = value; }
        
        /// <summary>
        /// Имя оператора
        /// </summary>
        public string Name { get => GetName(); }

        internal abstract string GetName();

        /// <summary>
        /// Аргументы оператора
        /// </summary>
        public string[] Arguments { get => arguments; set => arguments = value; }
        
        /// <summary>
        /// Комментарий к оператору
        /// </summary>
        public string Comment { get => comment; set => comment = value; }

        /// <summary>
        /// Возвращает код, соответствующий оператору
        /// </summary>
        /// <returns></returns>
        public virtual string Code
        {
            get
            {
                string result = $"{(label is null or "" ? string.Empty : label)} {Name}";
                for (int i = 0; i < arguments.Length - 1; i++)
                    result += $"{arguments[i]}, ";
                result += comment is null or "" ? "" : $"; {comment}";
                return result;
            }
        }
        #endregion Свойства

        #region Методы
        /// <summary>
        /// Проверяет корректность и совместимость параметров
        /// </summary>
        /// <returns></returns>
        public abstract bool Validate();
        #endregion Методы
    }
}
