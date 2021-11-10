namespace ArgentPonyWarcraftClient;

/// <summary>
/// Pet ability media.
/// </summary>
public record PetAbilityMedia
{
    /// <summary>
    /// Gets links for the pet ability media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the pet ability.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
