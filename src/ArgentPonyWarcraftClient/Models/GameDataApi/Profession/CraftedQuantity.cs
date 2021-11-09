namespace ArgentPonyWarcraftClient;

/// <summary>
/// A range of item quantities produced by a recipe.
/// </summary>
/// <remarks>
/// The crafted quantity will either have a value for <see cref="Value"/> or for <see cref="Minimum"/> and <see cref="Maximum"/>.
/// </remarks>
public record CraftedQuantity
{
    /// <summary>
    /// Gets the minimum number of the item produced.
    /// </summary>
    [JsonPropertyName("minimum")]
    public float? Minimum { get; init; }

    /// <summary>
    /// Gets the maximum number of the item produced.
    /// </summary>
    [JsonPropertyName("maximum")]
    public float? Maximum { get; init; }

    /// <summary>
    /// Gets the exact number of the item produced.
    /// </summary>
    [JsonPropertyName("value")]
    public float? Value { get; init; }
}
