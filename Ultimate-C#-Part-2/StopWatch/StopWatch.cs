using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime _start;
        private bool _running = false;

        public string Start()
        {
            if (_running == true)
            {
                throw new Exception("Stopwatch currently running.");
            }
            else
            {
                this._start = DateTime.Now;
                this._running = true;
                return "Started!";
            }
        }

        public TimeSpan Stop()
        {
            if (_running == true)
            {
                _running = false;
                return DateTime.Now - _start;
            }
            else;
            {
                throw new Exception("Stopwatch is not currently running.");
            }
        }
    }
}
