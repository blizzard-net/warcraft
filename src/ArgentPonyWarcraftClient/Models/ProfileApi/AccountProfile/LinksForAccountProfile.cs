namespace ArgentPonyWarcraftClient;

/// <summary>
/// Links associated with a user profile.
/// </summary>
public record LinksForAccountProfile
{
    /// <summary>
    /// Gets a self-reference.
    /// </summary>
    [JsonPropertyName("self")]
    public Self Self { get; init; }

    /// <summary>
    /// Gets a link to the user.
    /// </summary>
    [JsonPropertyName("user")]
    public Self User { get; init; }

    /// <summary>
    /// Gets a link to the profile.
    /// </summary>
    [JsonPropertyName("profile")]
    public Self Profile { get; init; }
}
