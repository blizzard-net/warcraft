namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents a talent entry in specialization loadouts.
/// </summary>
public record LoadoutTalent
{
    /// <summary>
    /// Gets the ID of the loadout talent.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; init; }

    /// <summary>
    /// Gets the rank of the loadout talent.
    /// </summary>
    [JsonPropertyName("rank")]
    public long Rank { get; init; }

    /// <summary>
    /// Gets the tooltip for the loadout talent.
    /// </summary>
    [JsonPropertyName("tooltip")]
    public TalentNodeTooltip Tooltip { get; init; }
}
