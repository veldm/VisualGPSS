using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.PLUS
{
    public static class Base
    {
        private enum Type
        {
            DistribRule, Math, String
        }

        public static List<string> Functions =>
            (from item in ps.ToList() select $"{item.name}{item.paramsSignature}").ToList();

        public static List<string> FunctionsHeaders =>
            (from item in ps.ToList() select item.name).ToList();

        public static List<string> DistribRules =>
            (from item in ps.ToList() where item.type is Type.DistribRule
             select $"({item.name}{item.paramsSignature})").ToList();

        public static List<string> DistribRulesHeaders =>
            (from item in ps.ToList() where item.type is Type.DistribRule
             select item.name).ToList();

        private static (Type type, string name, string paramsSignature)[] ps =
        {
            (Type.DistribRule, "Exponential", "(Генератор, Сдвиг, Сжатие)"),
            (Type.DistribRule, "Lognormal", "(Генератор, Сдвиг, Сжатие, Форма)"),
            (Type.DistribRule, "Gamma", "(Генератор, Сдвиг, Сжатие, Форма)"),
            (Type.DistribRule, "Weibull", "(Генератор, Сдвиг, Форма)"),
            (Type.DistribRule, "Poisson", "(Генератор, Значение)"),
            (Type.DistribRule, "Normal", "(Генератор, Значение, Отклонение)"),
            (Type.DistribRule, "Uniform", "(Генератор, Минимум, Максимум)"),
            (Type.DistribRule, "Duniform", "(Генератор, Минимум, Максимум)"),
        };
    }
}
