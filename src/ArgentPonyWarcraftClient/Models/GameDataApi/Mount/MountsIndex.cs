namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of mounts.
/// </summary>
public record MountsIndex
{
    /// <summary>
    /// Gets links for the index of mounts.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets references to the mounts.
    /// </summary>
    [JsonPropertyName("mounts")]
    public MountReference[] Mounts { get; init; }
}
