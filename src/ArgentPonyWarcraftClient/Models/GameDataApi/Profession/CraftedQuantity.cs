using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A range of item quantities produced by a recipe.
    /// </summary>
    public record CraftedQuantity
    {
        /// <summary>
        /// Gets the minimum number of the item produced.
        /// </summary>
        [JsonPropertyName("minimum")]
        public float Minimum { get; init; }

        /// <summary>
        /// Gets the maximum number of the item produced.
        /// </summary>
        [JsonPropertyName("maximum")]
        public float Maximum { get; init; }
    }
}
