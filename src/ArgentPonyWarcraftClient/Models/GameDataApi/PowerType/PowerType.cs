namespace ArgentPonyWarcraftClient;

/// <summary>
/// A power type.
/// </summary>
public record PowerType
{
    /// <summary>
    /// Gets links for the power type.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the power type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the power type.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
