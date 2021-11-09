namespace ArgentPonyWarcraftClient;

/// <summary>
/// A battle pet belonging to a World of Warcraft account.
/// </summary>
public record AccountPet
{
    /// <summary>
    /// Gets a reference to the species of the pet.
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
    /// Gets the pet stats.
    /// </summary>
    [JsonPropertyName("stats")]
    public PetStats Stats { get; init; }

    /// <summary>
    /// Gets a reference to the creature display media for the pet.
    /// </summary>
    [JsonPropertyName("creature_display")]
    public CreatureDisplayMediaReference CreatureDisplay { get; init; }

    /// <summary>
    /// Gets the ID of the pet.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet is a favorite.
    /// </summary>
    [JsonPropertyName("is_favorite")]
    public bool? IsFavorite { get; init; }

    /// <summary>
    /// Gets a value indicating whether the pet is currently active.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; init; }

    /// <summary>
    /// Gets the slot number if the pet is currently active.
    /// </summary>
    [JsonPropertyName("active_slot")]
    public int? ActiveSlot { get; init; }
}
