using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ArgentPonyWarcraftClient.Integration.Tests;

[Serializable]
internal class ResilientTestCase : XunitTestCase
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Called by the de-serializer", true)]
    public ResilientTestCase() { }

    public ResilientTestCase(IMessageSink diagnosticMessageSink, TestMethodDisplay testMethodDisplay, ITestMethod testMethod)
        : base(diagnosticMessageSink, testMethodDisplay, TestMethodDisplayOptions.None, testMethod, testMethodArguments: null)
    {
    }

    public override async Task<RunSummary> RunAsync(IMessageSink diagnosticMessageSink,
        IMessageBus messageBus,
        object[] constructorArguments,
        ExceptionAggregator aggregator,
        CancellationTokenSource cancellationTokenSource)
    {
        const int maxRetries = 3;
        var runCount = 0;

        while (true)
        {
            // Capture and delay messages until we've decided to accept the final result.
            var resilientMessageBus = new ResilientMessageBus(messageBus);

            var summary = await base.RunAsync(diagnosticMessageSink, resilientMessageBus, constructorArguments, aggregator, cancellationTokenSource);
            if (aggregator.HasExceptions || summary.Failed == 0 || ++runCount >= maxRetries || !resilientMessageBus.CanRetry)
            {
                resilientMessageBus.Dispose(); // Sends all the delayed messages.
                return summary;
            }

            diagnosticMessageSink.OnMessage(new DiagnosticMessage($"Execution of '{DisplayName}' failed (attempt #{runCount}), retrying..."));
            Thread.Sleep(TimeSpan.FromMilliseconds(1000 * Math.Pow(2, runCount)));
        }
    }
}
