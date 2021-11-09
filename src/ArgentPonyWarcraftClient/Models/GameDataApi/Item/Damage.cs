namespace ArgentPonyWarcraftClient;

/// <summary>
/// Item damage.
/// </summary>
public record Damage
{
    /// <summary>
    /// Gets the minimum damage.
    /// </summary>
    [JsonPropertyName("min_value")]
    public int MinValue { get; init; }

    /// <summary>
    /// Gets the maximum damage.
    /// </summary>
    [JsonPropertyName("max_value")]
    public int MaxValue { get; init; }

    /// <summary>
    /// Gets the display string that describes the damage.
    /// </summary>
    [JsonPropertyName("display_string")]
    public string DisplayString { get; init; }

    /// <summary>
    /// Gets the damage class.
    /// </summary>
    [JsonPropertyName("damage_class")]
    public EnumType DamageClass { get; init; }
}
