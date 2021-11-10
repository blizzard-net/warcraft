namespace ArgentPonyWarcraftClient;

/// <summary>
/// A pet ability for a specific pet species.
/// </summary>
public record SpeciesPetAbility
{
    /// <summary>
    /// Gets a reference to the pet ability.
    /// </summary>
    [JsonPropertyName("ability")]
    public PetAbilityReference Ability { get; init; }

    /// <summary>
    /// Gets the slot number for the pet ability.
    /// </summary>
    [JsonPropertyName("slot")]
    public int Slot { get; init; }

    /// <summary>
    /// Gets the required pet level to use the pet ability.
    /// </summary>
    [JsonPropertyName("required_level")]
    public int RequiredLevel { get; init; }
}
