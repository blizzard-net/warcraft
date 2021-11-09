namespace ArgentPonyWarcraftClient;

/// <summary>
/// A PvP tier.
/// </summary>
public record PvpTier
{
    /// <summary>
    /// Gets links for the PvP tier.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the PvP tier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the PvP tier.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the minimum rating for the PvP tier.
    /// </summary>
    [JsonPropertyName("min_rating")]
    public int MinRating { get; init; }

    /// <summary>
    /// Gets the maximum rating for the PvP tier.
    /// </summary>
    [JsonPropertyName("max_rating")]
    public int MaxRating { get; init; }

    /// <summary>
    /// Gets the media associated with the PvP tier.
    /// </summary>
    [JsonPropertyName("media")]
    public Media Media { get; init; }

    /// <summary>
    /// Gets the bracket for the PvP tier.
    /// </summary>
    [JsonPropertyName("bracket")]
    public Bracket Bracket { get; init; }

    /// <summary>
    /// Gets the rating type for the PvP tier.
    /// </summary>
    [JsonPropertyName("rating_type")]
    public int RatingType { get; init; }
}
