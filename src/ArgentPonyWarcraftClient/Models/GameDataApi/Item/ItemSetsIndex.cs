namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of item sets.
/// </summary>
public record ItemSetsIndex
{
    /// <summary>
    /// Gets links for the index of item sets.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to item sets.
    /// </summary>
    [JsonPropertyName("item_sets")]
    public ItemSetReference[] ItemSets { get; init; }
}
