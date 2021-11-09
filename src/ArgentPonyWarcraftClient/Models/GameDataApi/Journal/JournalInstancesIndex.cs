namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of instances.
/// </summary>
public record JournalInstancesIndex
{
    /// <summary>
    /// Gets links for the index of instances.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the instances.
    /// </summary>
    [JsonPropertyName("instances")]
    public InstanceReference[] Instances { get; init; }
}
