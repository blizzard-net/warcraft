namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of item classes.
/// </summary>
public record ItemClassesIndex
{
    /// <summary>
    /// Gets links for the index of item classes.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to item classes.
    /// </summary>
    [JsonPropertyName("item_classes")]
    public ItemClassReference[] ItemClasses { get; init; }
}
