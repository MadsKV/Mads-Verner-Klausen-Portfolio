using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace GuessANumber
{
    public class GetTimer
    {
        public static Timer aTimer { get; private set; }
        public static void SetTimer()
        {
            aTimer = new System.Timers.Timer(1000000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed at {mm:ss.fff}", e.SignalTime);
        }
    }
}
