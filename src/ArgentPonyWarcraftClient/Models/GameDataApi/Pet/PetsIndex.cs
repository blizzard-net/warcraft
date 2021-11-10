namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of pets.
/// </summary>
public record PetsIndex
{
    /// <summary>
    /// Gets links for the index of pets.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to pets.
    /// </summary>
    [JsonPropertyName("pets")]
    public PetReference[] Pets { get; init; }
}
