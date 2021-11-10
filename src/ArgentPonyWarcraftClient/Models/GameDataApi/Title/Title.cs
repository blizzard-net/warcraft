namespace ArgentPonyWarcraftClient;

/// <summary>
/// A title for a character.
/// </summary>
public record Title
{
    /// <summary>
    /// Gets links for the title.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the title.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the title.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the gender-specific names for the title.
    /// </summary>
    [JsonPropertyName("gender_name")]
    public GenderName GenderName { get; init; }
}
