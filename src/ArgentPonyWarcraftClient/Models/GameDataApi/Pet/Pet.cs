namespace ArgentPonyWarcraftClient;

/// <summary>
/// A pet.
/// </summary>
public record Pet
{
    /// <summary>
    /// Gets links for the pet.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the pet.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the pet.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the battle pet type.
    /// </summary>
    [JsonPropertyName("battle_pet_type")]
    public BattlePetType BattlePetType { get; init; }

    /// <summary>
    /// Gets a description of the pet.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet can be captured by a player.
    /// </summary>
    [JsonPropertyName("is_capturable")]
    public bool IsCapturable { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet can be traded to another player.
    /// </summary>
    [JsonPropertyName("is_tradable")]
    public bool IsTradable { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet can participate in pet battles.
    /// </summary>
    [JsonPropertyName("is_battlepet")]
    public bool IsBattlePet { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet is only available to Alliance players.
    /// </summary>
    [JsonPropertyName("is_alliance_only")]
    public bool IsAllianceOnly { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet is only available to Horde players.
    /// </summary>
    [JsonPropertyName("is_horde_only")]
    public bool IsHordeOnly { get; init; }

    /// <summary>
    /// Gets the pet abilities for this pet.
    /// </summary>
    [JsonPropertyName("abilities")]
    public SpeciesPetAbility[] Abilities { get; init; }

    /// <summary>
    /// Gets the source where the pet can be acquired.
    /// </summary>
    [JsonPropertyName("source")]
    public EnumType Source { get; init; }

    /// <summary>
    /// Gets a URI for the pet's icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public Uri Icon { get; init; }

    /// <summary>
    /// Gets a reference to the creature data for this pet.
    /// </summary>
    [JsonPropertyName("creature")]
    public CreatureReference Creature { get; init; }

    /// <summary>
    /// Gets a value indicating whether the creature display for this pet is random every time the pet is summoned.
    /// </summary>
    [JsonPropertyName("is_random_creature_display")]
    public bool IsRandomCreatureDisplay { get; init; }

    /// <summary>
    /// Gets a reference to the pet media.
    /// </summary>
    [JsonPropertyName("media")]
    public PetMediaReference Media { get; init; }
}
