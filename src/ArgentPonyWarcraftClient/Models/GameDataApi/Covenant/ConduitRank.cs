namespace ArgentPonyWarcraftClient;

/// <summary>
/// A conduit rank.
/// </summary>
public record ConduitRank
{
    /// <summary>
    /// Gets the Id of the conduit rank.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the tier of the conduit rank.
    /// </summary>
    [JsonPropertyName("tier")]
    public long Tier { get; init; }

    /// <summary>
    /// Gets the spell tooltip of the conduit rank.
    /// </summary>
    [JsonPropertyName("spell_tooltip")]
    public SpellTooltip SpellTooltip { get; init; }
}
