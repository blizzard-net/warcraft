using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     Queue manager which grand access not often then 100 times per second 
    /// </summary>
    public class QueueManager : IQueueManager
    {
        private Queue<AutoResetEvent> _queue;
        private CancellationTokenSource _cancelator;
        private Queue<DateTime> _sentTimes;
        private object _syncObject = new object();
        private static int _maxRequestPerSecond = 100;
        private static int _second = 1000;

        /// <summary>
        ///     Queue manager which grand access not often then 100 times per second 
        /// </summary>
        public QueueManager()
        {
            _queue = new Queue<AutoResetEvent>();
            _cancelator = new CancellationTokenSource();
            _sentTimes = new Queue<DateTime>();
            Task.Run(CheckAndGrand, _cancelator.Token);
        }

        /// <summary>
        ///     Wait untill acces granted.
        /// </summary>
        public void WaitForAccessToSend()
        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            lock(_syncObject)
            {
                _queue.Enqueue(autoEvent);
            }
            autoEvent.WaitOne();
            autoEvent.Dispose();
        }

        /// <summary>
        ///     Stop grant access
        /// </summary>
        public void Dispose()
        {

            _cancelator.Cancel();
        }


        private void CheckAndGrand()
        {
            while (true)
            {
                lock(_syncObject)
                {
                    if(_queue.Count > 0)
                    {
                        if(_sentTimes.Count == _maxRequestPerSecond)
                        {
                            double delta = (DateTime.Now - _sentTimes.Dequeue()).TotalMilliseconds;
                            if(delta <= 1 * _second)
                            {
                                Thread.Sleep((int)(1000 - delta));
                            }
                        }
                        _queue.Dequeue().Set();
                        _sentTimes.Enqueue(DateTime.Now);
                    }
                }
            }
        }
    }
}
