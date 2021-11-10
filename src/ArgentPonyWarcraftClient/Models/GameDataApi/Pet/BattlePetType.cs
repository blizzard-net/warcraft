namespace ArgentPonyWarcraftClient;

/// <summary>
/// A battle pet type.
/// </summary>
public record BattlePetType
{
    /// <summary>
    /// Gets the ID of the battle pet type.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the type of the battle pet type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }

    /// <summary>
    /// Gets the name of the battle pet type.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
