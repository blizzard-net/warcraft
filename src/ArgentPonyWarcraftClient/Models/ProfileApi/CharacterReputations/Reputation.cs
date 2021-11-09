namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's reputation with a faction.
/// </summary>
public record Reputation
{
    /// <summary>
    /// Gets a reference to the reputation faction.
    /// </summary>
    [JsonPropertyName("faction")]
    public ReputationFactionReference Faction { get; init; }

    /// <summary>
    /// Gets the character's standing with the reputation faction.
    /// </summary>
    [JsonPropertyName("standing")]
    public Standing Standing { get; init; }

    /// <summary>
    /// Gets the character's paragon status with the reputation faction.
    /// </summary>
    [JsonPropertyName("paragon")]
    public Paragon Paragon { get; init; }
}
