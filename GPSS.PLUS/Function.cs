using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.PLUS
{
    public class Function
    {
        private string name;
        private string operand1;
        private string operand2;
        private List<KeyValuePair<string, string>> values;

        public string Name { get => name; set => name = value; }
        public string NameToCall => $"FN${name}";
        public string Operand1 { get => operand1; set => operand1 = value; }
        public string Operand2 { get => operand2; set => operand2 = value; }
        
        [DisplayName("Значения")]
        public List<KeyValuePair<string, string>> Values { get => values; set => values = value; }

        public Function()
        {
            values = new List<KeyValuePair<string, string>>();
        }

        public Function(string name, string operand1, string operand2, List<KeyValuePair<string, string>> values)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.operand1 = operand1 ?? throw new ArgumentNullException(nameof(operand1));
            this.operand2 = operand2 ?? throw new ArgumentNullException(nameof(operand2));
            this.values = values ?? throw new ArgumentNullException(nameof(values));
        }

        public string Code
        {
            get
            {
                string result = $"{ToString()}\n";
                foreach (KeyValuePair<string, string> pair in values)
                    result += $"{pair.Key},{pair.Value}{(pair.Equals(values.Last()) ? "" : "/")}";
                return result.Replace("0.", ".");
            }
        }

        public override string ToString()
        {
            return $"{name} FUNCTION {Operand1},{Operand2}";
        }
    }
}
