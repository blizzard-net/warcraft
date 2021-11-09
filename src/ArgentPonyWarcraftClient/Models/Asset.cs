namespace ArgentPonyWarcraftClient;

/// <summary>
/// A media asset.
/// </summary>
public record Asset
{
    /// <summary>
    /// Gets the key of the asset.
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }

    /// <summary>
    /// Gets a URI for retrieving the asset value.
    /// </summary>
    [JsonPropertyName("value")]
    public Uri Value { get; init; }

    /// <summary>
    /// Gets the file data id for the asset.
    /// </summary>
    [JsonPropertyName("file_data_id")]
    public long FileDataId { get; init; }
}
