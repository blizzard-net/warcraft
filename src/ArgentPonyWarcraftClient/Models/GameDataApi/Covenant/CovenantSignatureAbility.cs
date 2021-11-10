namespace ArgentPonyWarcraftClient;

/// <summary>
/// A covenant signature ability.
/// </summary>
public record CovenantSignatureAbility
{
    /// <summary>
    /// Gets the Id for the covenant's signature ability.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the spell tooltip for the signature ability.
    /// </summary>
    [JsonPropertyName("spell_tooltip")]
    public SpellTooltip SpellTooltip { get; init; }
}
