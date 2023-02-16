using GPSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualGPSS
{
    static class DataSelecter
    {
        public static List<string> GetDataSource(this DataType dataType,
            GPSS.Visualiztion.VisualGPSS_Schema schema, out List<string> Values)
        {
            List<string> res = new();
            Values = new();
            switch (dataType)
            {
                case DataType.Device:
                    res.AddRange(schema.Devices.Select(dev => dev.Name));
                    break;
                case DataType.Label:
                    res.AddRange(schema.LabelsList);
                    break;
                case DataType.Math:
                    res.AddRange(schema.Functions.Select(func => func.Name));
                    Values.AddRange(schema.Functions.Select(func => func.NameToCall));
                    res.AddRange(GPSS.PLUS.Base.DistribRulesHeaders);
                    Values.AddRange(GPSS.PLUS.Base.DistribRules);
                    break;
                case DataType.BooleanAttitude:
                    foreach (var vs in Enum.GetValues(typeof(BooleanAttitude)))
                        res.Add(((BooleanAttitude)vs).DisplayName());
                    Values.AddRange(Enum.GetNames(typeof(BooleanAttitude)));
                    break;
                case DataType.DeviceCondition:
                    foreach (var vs in Enum.GetValues(typeof(DeviceCondition)))
                        res.Add(((DeviceCondition)vs).DisplayName());
                    Values.AddRange(Enum.GetNames(typeof(DeviceCondition)));
                    break;
                case DataType.Priority:
                    res.Add("PR");
                    break;
                case DataType.PreemptRegime:
                    res.Add("RE");
                    break;
                case DataType.FunavailRegime:
                    res.AddRange(new string[] { "RE", "CO" });
                    break;
            }
            return res;
        }
    }
}
