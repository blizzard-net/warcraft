namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP talent belonging to a playable specialization.
/// </summary>
public record PvpTalentElement
{
    /// <summary>
    /// Gets a reference to the PvP talent.
    /// </summary>
    [JsonPropertyName("talent")]
    public PvpTalentReference Talent { get; init; }

    /// <summary>
    /// Gets the spell tooltip for the PvP talent.
    /// </summary>
    [JsonPropertyName("spell_tooltip")]
    public SpellTooltip SpellTooltip { get; init; }
}
