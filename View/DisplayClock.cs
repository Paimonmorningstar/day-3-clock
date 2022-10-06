using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day_3_clock
{
    public class DisplayClock
    {
        public void Subcribe(Clock clock)
        {
            clock.clocktick += new Clock.clockTickHandler(ShowClock);
        }
        public void ShowClock(object clock, ClockEventArgs clockEventArgs)
        {
            Console.WriteLine($"Time now: {clockEventArgs.hour} : {clockEventArgs.minute} : {clockEventArgs.second}");
        }
    }
}