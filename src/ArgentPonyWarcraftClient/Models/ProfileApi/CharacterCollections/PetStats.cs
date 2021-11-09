namespace ArgentPonyWarcraftClient;

/// <summary>
/// Character pet stats.
/// </summary>
public record PetStats
{
    /// <summary>
    /// Gets the breed ID of the pet.
    /// </summary>
    [JsonPropertyName("breed_id")]
    public int BreedId { get; init; }

    /// <summary>
    /// Gets the health of the pet.
    /// </summary>
    [JsonPropertyName("health")]
    public int Health { get; init; }

    /// <summary>
    /// Gets the power of the pet.
    /// </summary>
    [JsonPropertyName("power")]
    public int Power { get; init; }

    /// <summary>
    /// Gets the speed of the pet.
    /// </summary>
    [JsonPropertyName("speed")]
    public int Speed { get; init; }
}
