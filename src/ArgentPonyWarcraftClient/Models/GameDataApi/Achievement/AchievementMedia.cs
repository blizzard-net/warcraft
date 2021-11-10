namespace ArgentPonyWarcraftClient;

/// <summary>
/// Achievement media.
/// </summary>
public record AchievementMedia
{
    /// <summary>
    /// Gets links for the achievement media.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a collection of media assets.
    /// </summary>
    [JsonPropertyName("assets")]
    public Asset[] Assets { get; init; }

    /// <summary>
    /// Gets the Id of the achievement that the media belongs to.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }
}
