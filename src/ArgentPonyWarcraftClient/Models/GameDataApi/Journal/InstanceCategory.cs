namespace ArgentPonyWarcraftClient;

/// <summary>
/// The category of the instance (i.e., "DUNGEON" or "RAID").
/// </summary>
public record InstanceCategory
{
    /// <summary>
    /// Gets the type of the instance category.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }
}
