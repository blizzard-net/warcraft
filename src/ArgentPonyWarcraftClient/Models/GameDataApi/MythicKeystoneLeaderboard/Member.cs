namespace ArgentPonyWarcraftClient;

/// <summary>
/// A group member.
/// </summary>
public record Member
{
    /// <summary>
    /// Gets the profile of the character.
    /// </summary>
    [JsonPropertyName("profile")]
    public Profile Profile { get; init; }

    /// <summary>
    /// Gets the character's faction (Alliance or Horde).
    /// </summary>
    [JsonPropertyName("faction")]
    public EnumTypeWithoutName Faction { get; init; }

    /// <summary>
    /// Gets the character's specialization.
    /// </summary>
    [JsonPropertyName("specialization")]
    public PlayableSpecializationReferenceWithoutName Specialization { get; init; }
}
