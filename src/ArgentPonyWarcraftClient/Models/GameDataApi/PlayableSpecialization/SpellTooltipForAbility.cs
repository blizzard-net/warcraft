namespace ArgentPonyWarcraftClient;

/// <summary>
/// A spell tooltip.
/// </summary>
public record SpellTooltipForAbility
{
    /// <summary>
    /// Gets a reference to the spell.
    /// </summary>
    [JsonPropertyName("spell")]
    public SpellReference Spell { get; init; }

    /// <summary>
    /// Gets the description of the spell.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the cast time of the spell.
    /// </summary>
    [JsonPropertyName("cast_time")]
    public string CastTime { get; init; }

    /// <summary>
    /// Gets the cooldown of the spell.
    /// </summary>
    [JsonPropertyName("cooldown")]
    public string Cooldown { get; init; }
}
