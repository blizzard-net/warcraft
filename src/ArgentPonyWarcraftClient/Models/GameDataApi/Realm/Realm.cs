namespace ArgentPonyWarcraftClient;

/// <summary>
/// A realm.
/// </summary>
public record Realm
{
    /// <summary>
    /// Gets links for the realm.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the ID of the realm.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a reference to the region to which this realm belongs.
    /// </summary>
    [JsonPropertyName("region")]
    public RegionReference Region { get; init; }

    /// <summary>
    /// Gets a reference to the connected realm.
    /// </summary>
    [JsonPropertyName("connected_realm")]
    public Self ConnectedRealm { get; init; }

    /// <summary>
    /// Gets the name of the realm.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the category of the realm.
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; init; }

    /// <summary>
    /// Gets the locale of the realm.
    /// </summary>
    [JsonPropertyName("locale")]
    public string Locale { get; init; }

    /// <summary>
    /// Gets the time zone for the realm.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string Timezone { get; init; }

    /// <summary>
    /// Gets the realm type.
    /// </summary>
    [JsonPropertyName("type")]
    public EnumType Type { get; init; }

    /// <summary>
    /// Gets a value indicating whether this is a tournament realm.
    /// </summary>
    [JsonPropertyName("is_tournament")]
    public bool IsTournament { get; init; }

    /// <summary>
    /// Gets the slug for the realm.
    /// </summary>
    [JsonPropertyName("slug")]
    public string Slug { get; init; }
}
