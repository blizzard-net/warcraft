namespace ArgentPonyWarcraftClient;

/// <summary>
/// A selected azerite essence.
/// </summary>
public record SelectedEssence
{
    /// <summary>
    /// Gets the slot of the selected essence.
    /// </summary>
    [JsonPropertyName("slot")]
    public int Slot { get; init; }

    /// <summary>
    /// Gets the rank of the selected essence.
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; init; }

    /// <summary>
    /// Gets the main spell tooltip.
    /// </summary>
    [JsonPropertyName("main_spell_tooltip")]
    public SpellTooltip MainSpellTooltip { get; init; }

    /// <summary>
    /// Gets the passive spell tooltip.
    /// </summary>
    [JsonPropertyName("passive_spell_tooltip")]
    public SpellTooltip PassiveSpellTooltip { get; init; }

    /// <summary>
    /// Gets a reference to the azerite essence.
    /// </summary>
    [JsonPropertyName("essence")]
    public AzeriteEssenceReference Essence { get; init; }

    /// <summary>
    /// Gets a reference to the azerite essence media.
    /// </summary>
    [JsonPropertyName("media")]
    public AzeritEssenceMediaReference Media { get; init; }
}
