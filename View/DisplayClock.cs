using System;

namespace Rookies3Clock
{
    public class DisplayClock
    {
        public void Subcribe(Clocks clock)
        {
            clock.clockTickEvent += new Clocks.clockTickHandler(ShowClock);
        }
        public void ShowClock(object clock, ClockEventArgs clockEventArgs)
        {
            Console.WriteLine(
                $"{clockEventArgs.hour} :{clockEventArgs.minute} :{clockEventArgs.second}"
                );
        }
    }
}