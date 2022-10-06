using System;

namespace Rookies3Clock
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clocks clocks1 = new Clocks();
            DisplayClock viewClock = new DisplayClock();
            viewClock.Subcribe(clocks1);
            clocks1.Run();
        }
    }
}