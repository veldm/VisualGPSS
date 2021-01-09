using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public partial class Comand : Operator
    {
        public enum ComandType
        { 
            /// <summary>
            /// 
            /// </summary>
            START,

            /// <summary>
            /// 
            /// </summary>
            STORAGE,

            /// <summary>
            /// 
            /// </summary>
            EQU
        }
    }
}
