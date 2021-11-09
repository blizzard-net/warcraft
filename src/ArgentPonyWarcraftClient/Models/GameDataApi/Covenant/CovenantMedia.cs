namespace ArgentPonyWarcraftClient;

/// <summary>
/// Media for a covenant.
/// </summary>
public record CovenantMedia
{
    /// <summary>
    /// Gets the key for this covenant media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }
}
