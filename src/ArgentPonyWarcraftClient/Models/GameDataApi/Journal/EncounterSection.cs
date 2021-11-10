namespace ArgentPonyWarcraftClient;

/// <summary>
/// A stage of an encounter in a dungeon or raid.
/// </summary>
public record EncounterSection
{
    /// <summary>
    /// Gets the ID of the section.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the title of the section.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; init; }

    /// <summary>
    /// Gets the body text that describes this section of the encounter.
    /// </summary>
    [JsonPropertyName("body_text")]
    public string BodyText { get; init; }

    /// <summary>
    /// Gets the media associated with this section.
    /// </summary>
    [JsonPropertyName("creature_display")]
    public Media CreatureDisplay { get; init; }

    /// <summary>
    /// Gets any child sections within this section.
    /// </summary>
    [JsonPropertyName("sections")]
    public EncounterSection[] Sections { get; init; }
}
