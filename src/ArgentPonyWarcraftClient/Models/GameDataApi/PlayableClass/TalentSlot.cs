namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP talent slot.
/// </summary>
public record TalentSlot
{
    /// <summary>
    /// Gets the PvP talent slot number.
    /// </summary>
    [JsonPropertyName("slot_number")]
    public int SlotNumber { get; init; }

    /// <summary>
    /// Gets the player level required to unlock the PvP talent slot.
    /// </summary>
    [JsonPropertyName("unlock_player_level")]
    public int UnlockPlayerLevel { get; init; }
}
