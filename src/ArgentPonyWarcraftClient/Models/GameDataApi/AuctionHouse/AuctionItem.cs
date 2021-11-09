namespace ArgentPonyWarcraftClient;

/// <summary>
/// An auction item.
/// </summary>
public record AuctionItem
{
    /// <summary>
    /// Gets the ID of the auction item.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the contex for the item.
    /// </summary>
    [JsonPropertyName("context")]
    public int? Context { get; init; }

    /// <summary>
    /// Gets the bonus lists for the item.
    /// </summary>
    [JsonPropertyName("bonus_lists")]
    public int[] BonusLists { get; init; }

    /// <summary>
    /// Gets the modifiers for the item.
    /// </summary>
    [JsonPropertyName("modifiers")]
    public Modifier[] Modifiers { get; init; }

    /// <summary>
    /// Gets the ID of the pet breed, if the item is a pet.
    /// </summary>
    [JsonPropertyName("pet_breed_id")]
    public int? PetBreedId { get; init; }

    /// <summary>
    /// Gets the pet level, if the item is a pet.
    /// </summary>
    [JsonPropertyName("pet_level")]
    public int? PetLevel { get; init; }

    /// <summary>
    /// Gets the ID of the pet quality ID, if the item is a pet.
    /// </summary>
    [JsonPropertyName("pet_quality_id")]
    public int? PetQualityId { get; init; }

    /// <summary>
    /// Gets the ID of the pet species ID, if the item is a pet.
    /// </summary>
    [JsonPropertyName("pet_species_id")]
    public int? PetSpeciesId { get; init; }
}
