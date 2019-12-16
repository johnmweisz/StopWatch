﻿using System;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime? _start = null;
        private DateTime? _stop = null;

        public void Start()
        {
            if (_start != null) throw new InvalidOperationException("StopWatch was already started.");
            _start = DateTime.Now;
            Console.WriteLine("Timer started.");
        }

        public void Stop()
        {
            if (_start == null) throw new InvalidOperationException("StopWatch was not started.");
            _stop = DateTime.Now;
            Console.WriteLine(Duration());
            _start = null;
        }

        private TimeSpan? Duration()
        {
            if (_stop == null || _start == null) throw new InvalidOperationException("Unable to calculate duration.");
            return _stop - _start;
        }
        
    }
}