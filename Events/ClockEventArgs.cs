using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day_3_clock
{
    public class ClockEventArgs
    {
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
        public ClockEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}