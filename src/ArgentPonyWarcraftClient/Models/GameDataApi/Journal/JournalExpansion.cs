namespace ArgentPonyWarcraftClient;

/// <summary>
/// A game expansion.
/// </summary>
public record JournalExpansion
{
    /// <summary>
    /// Gets links for the expansion.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the expansion.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the expansion.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the dungeons that belong to the expansion.
    /// </summary>
    [JsonPropertyName("dungeons")]
    public InstanceReference[] Dungeons { get; init; }

    /// <summary>
    /// Gets the raids that belong to the expansion.
    /// </summary>
    [JsonPropertyName("raids")]
    public InstanceReference[] Raids { get; init; }
}
