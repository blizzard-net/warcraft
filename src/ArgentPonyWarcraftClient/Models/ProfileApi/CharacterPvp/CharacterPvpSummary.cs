namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP summary for a character.
/// </summary>
public record CharacterPvpSummary
{
    /// <summary>
    /// Gets the links for the PvP summary for the character.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets links to the PvP brackets for the character.
    /// </summary>
    [JsonPropertyName("brackets")]
    public Self[] Brackets { get; init; }

    /// <summary>
    /// Gets the honor level of the character.
    /// </summary>
    [JsonPropertyName("honor_level")]
    public int HonorLevel { get; init; }

    /// <summary>
    /// Gets the PvP map statistics for the character.
    /// </summary>
    [JsonPropertyName("pvp_map_statistics")]
    public PvpMapStatistic[] PvpMapStatistics { get; init; }

    /// <summary>
    /// Gets the number of honorable kills for the character.
    /// </summary>
    [JsonPropertyName("honorable_kills")]
    public int HonorableKills { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }
}
