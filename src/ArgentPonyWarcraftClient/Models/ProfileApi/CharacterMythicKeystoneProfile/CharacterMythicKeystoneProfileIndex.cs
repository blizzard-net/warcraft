namespace ArgentPonyWarcraftClient;

/// <summary>
/// The Mythic Keystone profile index for a character.
/// </summary>
public record CharacterMythicKeystoneProfileIndex
{
    /// <summary>
    /// Gets links for the Mythic Keystone profile index.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the current Mythic Keystone period.
    /// </summary>
    [JsonPropertyName("current_period")]
    public CurrentPeriod CurrentPeriod { get; init; }

    /// <summary>
    /// Gets references to the Mythic Keystone season details for the character.
    /// </summary>
    [JsonPropertyName("seasons")]
    public CharacterMythicKeystoneSeasonDetailsReference[] Seasons { get; init; }

    /// <summary>
    /// Gets the character details.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets the current Mythic Rating value for the character.
    /// </summary>
    [JsonPropertyName("current_mythic_rating")]
    public MythicRating CurrentMythicRating { get; init; }
}
