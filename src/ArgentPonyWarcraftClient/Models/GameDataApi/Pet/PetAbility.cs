namespace ArgentPonyWarcraftClient;

/// <summary>
/// A battle pet ability.
/// </summary>
public record PetAbility
{
    /// <summary>
    /// Gets links for the pet ability.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the pet ability.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the pet ability.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the battle pet type for this pet ability.
    /// </summary>
    [JsonPropertyName("battle_pet_type")]
    public BattlePetType BattlePetType { get; init; }

    /// <summary>
    /// Gets the number of rounds for the pet ability cooldown.
    /// </summary>
    [JsonPropertyName("rounds")]
    public int Rounds { get; init; }

    /// <summary>
    /// Gets the media associated with this pet ability.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }
}
