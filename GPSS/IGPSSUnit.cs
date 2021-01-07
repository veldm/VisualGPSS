using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    interface IGPSSUnit
    {
        string GetCode();
        bool Validate();
    }
}
