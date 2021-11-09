namespace ArgentPonyWarcraftClient;

/// <summary>
/// A media asset.
/// </summary>
public record AssetWithoutFileDataId
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
}
