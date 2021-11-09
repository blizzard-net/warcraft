namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP talent selected by a character.
/// </summary>
public record PvpTalentElementForAbility
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
    public SpellTooltipForAbility SpellTooltip { get; init; }
}
