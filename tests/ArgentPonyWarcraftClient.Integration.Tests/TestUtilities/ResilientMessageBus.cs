using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ArgentPonyWarcraftClient.Integration.Tests
{
    internal class ResilientMessageBus : IMessageBus
    {
        private readonly IMessageBus _innerBus;
        private readonly List<IMessageSinkMessage> _messages = new List<IMessageSinkMessage>();

        public ResilientMessageBus(IMessageBus innerBus)
        {
            _innerBus = innerBus;
        }

        /// <summary>
        /// A value indicating whether the test encountered an exception that might be transient.
        /// </summary>
        public bool CanRetry { get; private set; } = false;

        public bool QueueMessage(IMessageSinkMessage message)
        {
            if (message is ITestFailed testFailed)
            {
                string exceptionType = testFailed.ExceptionTypes.FirstOrDefault();
                CanRetry = exceptionType == typeof(HttpRequestException).FullName;
            }

            lock (_messages)
            {
                _messages.Add(message);
            }

            return true;
        }

        public void Dispose()
        {
            foreach (var message in _messages)
            {
                _innerBus.QueueMessage(message);
            }
        }
    }
}
