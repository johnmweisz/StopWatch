using System;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime? _start;
        private DateTime? _stop;

        public void Start()
        {
            if (_start != null) throw new InvalidOperationException("StopWatch is already started.");
            _start = DateTime.Now;
            Console.WriteLine("Timer started.");
        }

        public void Stop()
        {
            if (_start == null) throw new InvalidOperationException("StopWatch is not started.");
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