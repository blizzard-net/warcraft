namespace ArgentPonyWarcraftClient;

/// <summary>
/// PvP tier media.
/// </summary>
public record PvpTierMedia
{
    /// <summary>
    /// Gets links for the PvP tier media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the PvP tier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
