namespace ArgentPonyWarcraftClient.Integration.Tests.TestUtilities;

/// <summary>
/// An exception that indicates no Blizzard credentials were configured.
/// </summary>
internal class NoCredentialsException : Exception
{
    public NoCredentialsException(string message)
        : base(message)
    {
    }
}
