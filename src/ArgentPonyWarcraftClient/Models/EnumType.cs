namespace ArgentPonyWarcraftClient;

/// <summary>
/// An enumerated type.
/// </summary>
public record EnumType
{
    /// <summary>
    /// Gets the type code for this enumerated value.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }

    /// <summary>
    /// Gets the name of the enumerated value.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
