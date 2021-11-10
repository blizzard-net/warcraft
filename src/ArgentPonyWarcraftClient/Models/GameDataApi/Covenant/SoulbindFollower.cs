namespace ArgentPonyWarcraftClient;

/// <summary>
/// A follower for a soulbind.
/// </summary>
public record SoulbindFollower
{
    /// <summary>
    /// Gets the Id of the follower.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name of the follower.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }
}
