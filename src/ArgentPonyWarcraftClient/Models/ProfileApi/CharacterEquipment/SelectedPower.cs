namespace ArgentPonyWarcraftClient;

/// <summary>
/// A selected azerite power.
/// </summary>
public record SelectedPower
{
    /// <summary>
    /// Gets the ID of the azerite power.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the tier for the azerite power.
    /// </summary>
    [JsonPropertyName("tier")]
    public int Tier { get; init; }

    /// <summary>
    /// Gets the spell tooltip for the azerite power.
    /// </summary>
    [JsonPropertyName("spell_tooltip")]
    public SpellTooltip SpellTooltip { get; init; }

    /// <summary>
    /// Gets a value indicating whether the display is hidden.
    /// </summary>
    [JsonPropertyName("is_display_hidden")]
    public bool? IsDisplayHidden { get; init; }
}
