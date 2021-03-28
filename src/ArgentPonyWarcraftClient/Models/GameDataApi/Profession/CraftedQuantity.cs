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
        public float Minimum { get; }

        /// <summary>
        /// Gets the maximum number of the item produced.
        /// </summary>
        [JsonPropertyName("maximum")]
        public float Maximum { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CraftedQuantity"/> class.
        /// </summary>
        /// <param name="minimum">The minimum number of the item produced.</param>
        /// <param name="maximum">The maximum number of the item produced.</param>
        [JsonConstructor]
        public CraftedQuantity(float minimum, float maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }
    }
}
