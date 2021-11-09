namespace ArgentPonyWarcraftClient;

/// <summary>
/// A reference to a PvP season.
/// </summary>
public record PvpSeasonReference
{
    /// <summary>
    /// Gets the key for the PvP season.
    /// </summary>
    [JsonPropertyName("key")]
    public Self Key { get; init; }

    /// <summary>
    /// Gets the ID of the PvP season.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
