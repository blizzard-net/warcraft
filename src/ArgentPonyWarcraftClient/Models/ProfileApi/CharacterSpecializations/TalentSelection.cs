namespace ArgentPonyWarcraftClient;

/// <summary> 
/// A talent selection for a character's specialization.
/// </summary>
public record TalentSelection
{
    /// <summary>
    /// Gets a reference to the talent.
    /// </summary>
    [JsonPropertyName("talent")]
    public TalentReference Talent { get; init; }

    /// <summary>
    /// Gets the spell tooltip for the talent.
    /// </summary>
    [JsonPropertyName("spell_tooltip")]
    public SpellTooltipForAbility SpellTooltip { get; init; }

    /// <summary>
    /// Gets the tier index for the talent.
    /// </summary>
    [JsonPropertyName("tier_index")]
    public int TierIndex { get; init; }

    /// <summary>
    /// Gets the column index for the talent.
    /// </summary>
    [JsonPropertyName("column_index")]
    public int ColumnIndex { get; init; }
}
