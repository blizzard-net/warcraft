namespace ArgentPonyWarcraftClient;

/// <summary>
/// A weapon.
/// </summary>
public record Weapon
{
    /// <summary>
    /// Gets the damage of the weapon.
    /// </summary>
    [JsonPropertyName("damage")]
    public Damage Damage { get; init; }

    /// <summary>
    /// Gets the attack speed of the weapon.
    /// </summary>
    [JsonPropertyName("attack_speed")]
    public DescribedValue AttackSpeed { get; init; }

    /// <summary>
    /// Gets the damage per second (DPS) of the weapon.
    /// </summary>
    [JsonPropertyName("dps")]
    public DescribedValue Dps { get; init; }
}
