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
        public string Name { get => GetName(); set { } }

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
                string result = $"{(label is null or "" ? "" : $"{label} ")}{Name} ";
                //for (int i = arguments.Length - 1; i > 0; i--)
                //{
                //    if (arguments[i] is not "")
                //    {
                //        for (int j = 0; !(j > i); j++)
                //            result += $"{arguments[j]},";
                //        break;
                //    }
                //}

                foreach (var item in from string item in arguments
                                     where item is not "" select item)
                    result += /*item != arguments.Last() ?*/ $"{item}," /*: $"{item}"*/;

                if (result.Last() is ',') result.Remove(result.Length - 1);
                //result += arguments.Last();
                result += comment is null or "" ? "" : $"; {comment}";
                return result;
            }
        }
        #endregion Свойства

        protected Operator(string label, string[] arguments, string comment)
        {
            this.label = label is not "" ? label : null;
            this.comment = comment is not "" ? comment : null;
            this.arguments = arguments ?? throw new ArgumentNullException(nameof(label));

            List<string> buf = this.arguments.ToList();
            for (int i = buf.Count - 1; i >= 0 && buf[i] is null or ""; i--) buf.RemoveAt(i);
            this.arguments = buf.ToArray();
        }

        #region Методы
        /// <summary>
        /// Проверяет корректность и совместимость параметров
        /// </summary>
        /// <returns></returns>
        public abstract bool Validate();
        #endregion Методы
    }
}
