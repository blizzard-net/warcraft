namespace ArgentPonyWarcraftClient;

/// <summary>
/// A stat modifier.
/// </summary>
public record Stat
{
    /// <summary>
    /// Gets the stat type.
    /// </summary>
    [JsonPropertyName("type")]
    public EnumType Type { get; init; }

    /// <summary>
    /// Gets the numerical value of the stat modifier.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; init; }

    /// <summary>
    /// Gets a value indicating whether the stat modifier is negated.
    /// </summary>
    [JsonPropertyName("is_negated")]
    public bool? IsNegated { get; init; }

    /// <summary>
    /// Gets the display details for the stat modifier.
    /// </summary>
    [JsonPropertyName("display")]
    public StatDisplay Display { get; init; }

    /// <summary>
    /// Gets a value indicating whether the stat modifier is an equip bonus.
    /// </summary>
    [JsonPropertyName("is_equip_bonus")]
    public bool? IsEquipBonus { get; init; }
}
