namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of PvP talents.
/// </summary>
public record PvpTalentsIndex
{
    /// <summary>
    /// Gets links for the index of PvP talents.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to PvP talents.
    /// </summary>
    [JsonPropertyName("pvp_talents")]
    public PvpTalentReference[] PvpTalents { get; init; }
}
