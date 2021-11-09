namespace ArgentPonyWarcraftClient;

/// <summary>
/// PvP talent slots for a playable class.
/// </summary>
public record PvpTalentSlots
{
    /// <summary>
    /// Gets links for the PvP talent slots.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the talent slots.
    /// </summary>
    [JsonPropertyName("talent_slots")]
    public TalentSlot[] TalentSlots { get; init; }
}
