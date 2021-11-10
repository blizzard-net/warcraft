namespace ArgentPonyWarcraftClient;

/// <summary>
/// Recipe media.
/// </summary>
public record RecipeMedia
{
    /// <summary>
    /// Gets links for the recipe media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the ID of the recipe.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
