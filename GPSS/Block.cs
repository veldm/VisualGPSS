using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public class Block
    {
        private string name;
        private bool isMultiChanell;
        private List<Comand> comands;

        public string Name { get => name; set => name = value; }
        public bool IsMultiChanell { get => isMultiChanell; set => isMultiChanell = value; }
        internal List<Comand> Comands { get => comands; set => comands = value; }
    }
}
