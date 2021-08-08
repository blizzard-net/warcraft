using System.Net.Http;
using System.Net.Http.Headers;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     QueueManagerFactory
    /// </summary>
    public static class QueueManagerFactory
    {
        private static IQueueManager _instance;

        /// <summary>
        ///     Gets the current IQueueManager instance.
        /// </summary>
        public static IQueueManager Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                else
                {
                    _instance = new QueueManager();

                    return _instance;
                }
            }
        }
    }
}
