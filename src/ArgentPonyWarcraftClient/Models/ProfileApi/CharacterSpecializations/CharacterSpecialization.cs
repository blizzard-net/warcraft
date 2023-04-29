namespace ArgentPonyWarcraftClient;

/// <summary>
/// A specialization for a character.
/// </summary>
public record CharacterSpecialization
{
    /// <summary>
    /// Gets a reference to the playable specialization.
    /// </summary>
    [JsonPropertyName("specialization")]
    public PlayableSpecializationReference Specialization { get; init; }

    /// <summary>
    /// Gets the character's selected talents.
    /// </summary>
    [JsonPropertyName("talents")]
    public TalentSelection[] Talents { get; init; }

    /// <summary>
    /// Gets the PvP talent slots for the specialization.
    /// </summary>
    [JsonPropertyName("pvp_talent_slots")]
    public PvpTalentSlot[] PvpTalentSlots { get; init; }

    /// <summary>
    /// Get the loadouts for the specialization.
    /// </summary>
    [JsonPropertyName("loadouts")]
    public SpecializationLoadout[] Loadouts { get; init; }
}
