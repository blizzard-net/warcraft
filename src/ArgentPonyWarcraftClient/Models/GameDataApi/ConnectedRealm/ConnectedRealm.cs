namespace ArgentPonyWarcraftClient;

/// <summary>
/// A connected realm.
/// </summary>
public record ConnectedRealm
{
    /// <summary>
    /// Gets links for the connected realm.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the connected realm.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a value indicating whether there is a queue to log in to the connected realm.
    /// </summary>
    [JsonPropertyName("has_queue")]
    public bool HasQueue { get; init; }

    /// <summary>
    /// Gets the status of the realm.
    /// </summary>
    [JsonPropertyName("status")]
    public EnumType Status { get; init; }

    /// <summary>
    /// Gets a rough indicator of the connected realm population.
    /// </summary>
    [JsonPropertyName("population")]
    public EnumType Population { get; init; }

    /// <summary>
    /// Gets the realms in the connected realm.
    /// </summary>
    [JsonPropertyName("realms")]
    public Realm[] Realms { get; init; }

    /// <summary>
    /// Gets a reference to the Mythic Keystone Leaderboard data for this connected realm.
    /// </summary>
    [JsonPropertyName("mythic_leaderboards")]
    public Self MythicLeaderboards { get; init; }

    /// <summary>
    /// Gets a reference to the auction house data for this connected realm.
    /// </summary>
    [JsonPropertyName("auctions")]
    public Self Auctions { get; init; }
}
