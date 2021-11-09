namespace ArgentPonyWarcraftClient;

/// <summary>
/// A specific pet that has been collected by a character.
/// </summary>
public record CharacterPet
{
    /// <summary>
    /// Gets a reference to the pet's species.
    /// </summary>
    [JsonPropertyName("species")]
    public PetReference Species { get; init; }

    /// <summary>
    /// Gets the level of the pet.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; init; }

    /// <summary>
    /// Gets the quality of the pet.
    /// </summary>
    [JsonPropertyName("quality")]
    public EnumType Quality { get; init; }

    /// <summary>
    /// Gets the stats for the pet.
    /// </summary>
    [JsonPropertyName("stats")]
    public PetStats Stats { get; init; }

    /// <summary>
    /// Gets the display information for the pet.
    /// </summary>
    [JsonPropertyName("creature_display")]
    public Media CreatureDisplay { get; init; }

    /// <summary>
    /// Gets the ID of the pet.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet has been selected as a favorite.
    /// </summary>
    [JsonPropertyName("is_favorite")]
    public bool? IsFavorite { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet is currently active.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; init; }

    /// <summary>
    /// Gets the active slot, if any, for the pet.
    /// </summary>
    [JsonPropertyName("active_slot")]
    public int? ActiveSlot { get; init; }
}
