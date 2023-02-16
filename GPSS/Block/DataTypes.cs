using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS
{
    public enum DataType
    {
        Math, Device, Label, BooleanAttitude, DeviceCondition, Priority,
        PreemptRegime, FunavailRegime
    }

    public enum BooleanAttitude
    {
        E, GE, G, LE, L, NE
    }

    public static class BooleanAttitudeExtexsions
    {
        public static string DisplayName(this BooleanAttitude attitude) =>
            DisplayNames[(int)attitude];
        
        private static string[] DisplayNames =
            { "Равно", "Больше или равно", "Больше", "Меньше или равно", "Меньше", "Не равно" };
    }


    public enum DeviceCondition
    {
        FV, FNV, I, NI, U, NU, SE, SNE, SF, SNF, SV, SNV, M, NM, LS, LR
    }

    public static class DeviceConditionExtexsions
    {
        public static string DisplayName(this DeviceCondition condition) =>
            DisplayNames[(int)condition];

        private static string[] DisplayNames =
        {
            "Устройство доступно", "Устройство недоступно", "Устройство прервано",
            "Устройство не прервано", "Устройство используется", "Устройство не используется",

        };
    }
}
