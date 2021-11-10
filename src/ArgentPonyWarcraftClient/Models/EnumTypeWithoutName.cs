namespace ArgentPonyWarcraftClient;

/// <summary>
/// An enumerated type.
/// </summary>
public record EnumTypeWithoutName
{
    /// <summary>
    /// Gets the type code for this enumerated value.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }
}
