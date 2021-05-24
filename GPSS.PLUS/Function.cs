using System;
using System.Collections.Generic;
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
        public string Operand1 { get => operand1; set => operand1 = value; }
        public string Operand2 { get => operand2; set => operand2 = value; }
        public List<KeyValuePair<string, string>> Values { get => values; set => values = value; }
        public string Code
        {
            get
            {
                string result = $"{ToString()}\n";
                foreach (KeyValuePair<string, string> pair in values)
                    result += $"{pair.Key},{pair.Value}{(pair.Equals(values.Last()) ? "" : "/")}";
                return result;
            }
        }

        public override string ToString()
        {
            return $"{name} FUNCTION {Operand1},{Operand2}";
        }
    }
}
