using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace GuessANumber
{
    class Timer
    {
        public Action<object, ElapsedEventArgs> Elapsed { get; internal set; }
    }
}
