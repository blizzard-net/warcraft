namespace ArgentPonyWarcraftClient;

/// <summary>
/// Journal instance media.
/// </summary>
public record JournalInstanceMedia
{
    /// <summary>
    /// Gets links for the journal instance media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public AssetWithoutFileDataId[] Assets { get; init; }
}
