namespace ArgentPonyWarcraftClient;

/// <summary>
/// A category of items.
/// </summary>
public record ItemClass
{
    /// <summary>
    /// Gets links for the item class.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the class ID for the item class.
    /// </summary>
    [JsonPropertyName("class_id")]
    public int ClassId { get; init; }

    /// <summary>
    /// Gets the name of the item class.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets references to the subclasses of this item class.
    /// </summary>
    [JsonPropertyName("item_subclasses")]
    public ItemSubclassReference[] ItemSubclasses { get; init; }
}
