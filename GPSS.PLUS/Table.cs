using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSS.PLUS
{
    public class Table
    {
        private string name;
        private string intervalMax;
        private string intervalWidth;
        private string intervalsCount;
        private string timeInterval_RT;

        public string Name { get => name; set => name = value; }
        public string IntervalMax { get => intervalMax; set => intervalMax = value; }
        public string IntervalWidth { get => intervalWidth; set => intervalWidth = value; }
        public string IntervalsCount { get => intervalsCount; set => intervalsCount = value; }
        public string TimeInterval_RT { get => timeInterval_RT; set => timeInterval_RT = value; }

        public Table() { }

        public Table(string name, string intervalMax, string intervalWidth,
            string intervalsCount, string timeInterval_RT = null)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.intervalMax = intervalMax ?? throw new ArgumentNullException(nameof(intervalMax));
            this.intervalWidth = intervalWidth ?? throw new ArgumentNullException(nameof(intervalWidth));
            this.intervalsCount = intervalsCount ?? throw new ArgumentNullException(nameof(intervalsCount));
            this.timeInterval_RT = timeInterval_RT;
        }

        public override string ToString()
        {
            return name;
        }

        public string Code
        {
            get
            {
                return $"{name} TABLE {IntervalMax},{IntervalWidth},{IntervalsCount}" +
                    $"{(TimeInterval_RT is not null ? $",{TimeInterval_RT}" : string.Empty)}";
            }
        }
    }
}
