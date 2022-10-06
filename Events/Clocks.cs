using System;

namespace Rookies3Clock
{
    public class Clocks
    {
        private int _second;
        public delegate void clockTickHandler(object clock, ClockEventArgs clockEventArgs);
        public event clockTickHandler? clockTickEvent;
        protected void Ontick(object clock, ClockEventArgs clockEventArgs)
        {
            if (clockTickEvent != null)
            {
                clockTickEvent(clock, clockEventArgs);

            }
        }
        public void Run()
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
                var time = DateTime.Now;
                if (time.Second != _second)
                {
                    var clockEventArgs = new ClockEventArgs(time.Hour, time.Minute, time.Second);
                    Ontick(this, clockEventArgs);
                }
            }
        }
    }
}