namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of pet abilities.
/// </summary>
public record PetAbilitiesIndex
{
    /// <summary>
    /// Gets links for the index of pet abilities.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the pet abilities.
    /// </summary>
    [JsonPropertyName("abilities")]
    public PetAbilityReference[] Abilities { get; init; }
}
