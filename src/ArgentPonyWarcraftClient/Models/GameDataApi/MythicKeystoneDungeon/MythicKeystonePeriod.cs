namespace ArgentPonyWarcraftClient;

/// <summary>
/// A mythic keystone period.
/// </summary>
public record MythicKeystonePeriod
{
    /// <summary>
    /// Gets links for the mythic keystone period.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the mythic keystone period.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the start timestampe of the mythic keystone period.
    /// </summary>
    [JsonPropertyName("start_timestamp")]
    public DateTimeOffset StartTimestamp { get; init; }

    /// <summary>
    /// Gets the end timestampe of the mythic keystone period.
    /// </summary>
    [JsonPropertyName("end_timestamp")]
    public DateTimeOffset EndTimestamp { get; init; }
}
