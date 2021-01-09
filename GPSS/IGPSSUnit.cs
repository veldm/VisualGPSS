using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public interface IGPSSUnit
    {
        /// <summary>
        /// Генерирует код, соответствующий элементу
        /// </summary>
        /// <returns></returns>
        string GetCode();
        
        /// <summary>
        /// Проверяет корректность и совместимость параметров
        /// </summary>
        /// <returns></returns>
        bool Validate();
    }
}
