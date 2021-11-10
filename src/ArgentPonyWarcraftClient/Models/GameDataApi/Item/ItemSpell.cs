namespace ArgentPonyWarcraftClient;

/// <summary>
/// Gets a spell associated with an item.
/// </summary>
public record ItemSpell
{
    /// <summary>
    /// Gets a reference to a spell.
    /// </summary>
    [JsonPropertyName("spell")]
    public SpellReference Spell { get; init; }

    /// <summary>
    /// Gets the description of the spell.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the RGBA display color for the spell.
    /// </summary>
    [JsonPropertyName("display_color")]
    public ColorDetails DisplayColor { get; init; }
}
