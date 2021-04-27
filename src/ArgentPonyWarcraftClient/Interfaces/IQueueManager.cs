using System;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     Queue manager which grand access not often then 100 times per second 
    /// </summary>
    public interface IQueueManager : IDisposable
    {
        /// <summary>
        ///     Wait untill acces granted.
        /// </summary>
        void WaitForAccessToSend();
    }
}
