namespace ArgentPonyWarcraftClient;

/// <summary>
/// A position in the game.
/// </summary>
public record Position
{
    /// <summary>
    /// Gets the zone.
    /// </summary>
    [JsonPropertyName("zone")]
    public Map Zone { get; init; }

    /// <summary>
    /// Gets the map.
    /// </summary>
    [JsonPropertyName("map")]
    public Map Map { get; init; }

    /// <summary>
    /// Gets the x coordinate.
    /// </summary>
    [JsonPropertyName("x")]
    public float X { get; init; }

    /// <summary>
    /// Gets the y coordinate.
    /// </summary>
    [JsonPropertyName("y")]
    public float Y { get; init; }

    /// <summary>
    /// Gets the z coordinate.
    /// </summary>
    [JsonPropertyName("z")]
    public float Z { get; init; }

    /// <summary>
    /// Gets the facing.
    /// </summary>
    [JsonPropertyName("facing")]
    public float Facing { get; init; }
}
