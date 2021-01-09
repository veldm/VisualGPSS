using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    class Comand
    {
        public enum ComandType
        { GENERATE, QUEUE, ADVANCE, RELEASE, ENTER, DEPART, LEAVE, TERMINATE }

        private ComandType type;
        private string[] arguments;
        private string comment;
        private Transfer transfer;

        internal ComandType Type { get => type; set => type = value; }
        public string[] Arguments { get => arguments; set => arguments = value; }
        public string Comment { get => comment; set => comment = value; }
        internal Transfer Transfer { get => transfer; set => transfer = value; }
    }
}
