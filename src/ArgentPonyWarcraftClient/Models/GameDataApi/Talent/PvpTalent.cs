namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP talent.
/// </summary>
public record PvpTalent
{
    /// <summary>
    /// Gets links for the PvP talent.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the PvP talent.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the spell associated with this talent.
    /// </summary>
    [JsonPropertyName("spell")]
    public SpellReference Spell { get; init; }

    /// <summary>
    /// Gets a reference to the playable specialization associated with this talent.
    /// </summary>
    [JsonPropertyName("playable_specialization")]
    public PlayableSpecializationReference PlayableSpecialization { get; init; }

    /// <summary>
    /// Gets a reference to the spell that this talent overrides.
    /// </summary>
    [JsonPropertyName("overrides_spell")]
    public SpellReference OverridesSpell { get; init; }

    /// <summary>
    /// Gets the description of the PvP talent.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the levle at which the player unlocks this PvP talent.
    /// </summary>
    [JsonPropertyName("unlock_player_level")]
    public int UnlockPlayerLevel { get; init; }

    /// <summary>
    /// Gets the compatible slots for this talent.
    /// </summary>
    [JsonPropertyName("compatible_slots")]
    public int[] CompatibleSlots { get; init; }
}
