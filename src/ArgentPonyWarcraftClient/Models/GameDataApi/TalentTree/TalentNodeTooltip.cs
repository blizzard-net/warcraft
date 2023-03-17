namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents a tooltip for a talent node.
/// </summary>
public record TalentNodeTooltip
{
    /// <summary>
    /// Gets a reference to the talent associated with this tooltip.
    /// </summary>
    [JsonPropertyName("talent")]
    public TalentReference Talent { get; init; }

    /// <summary>
    /// Gets the spell tooltip for the talent node.
    /// </summary>
    [JsonPropertyName("spell_tooltip")]
    public SpellTooltip SpellTooltip { get; init; }
}
