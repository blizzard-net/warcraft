using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A range of item quantities produced by a recipe.
    /// </summary>
    public class CraftedQuantity
    {
        /// <summary>
        /// Gets the minimum number of the item produced.
        /// </summary>
        [JsonProperty("minimum")]
        public long Minimum { get; set; }

        /// <summary>
        /// Gets the maximum number of the item produced.
        /// </summary>
        [JsonProperty("maximum")]
        public long Maximum { get; set; }
    }
}
