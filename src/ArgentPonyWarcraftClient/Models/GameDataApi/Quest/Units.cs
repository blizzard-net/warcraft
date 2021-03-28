using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A monetary amount as gold, silver, and copper units.
    /// </summary>
    public record Units
    {
        /// <summary>
        /// Gets the amount of gold.
        /// </summary>
        [JsonPropertyName("gold")]
        public long Gold { get; }

        /// <summary>
        /// Gets the amount of silver.
        /// </summary>
        [JsonPropertyName("silver")]
        public int Silver { get; }

        /// <summary>
        /// Gets the amount of copper.
        /// </summary>
        [JsonPropertyName("copper")]
        public int Copper { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Units"/> class.
        /// </summary>
        /// <param name="gold">The amount of gold.</param>
        /// <param name="silver">The amount of silver.</param>
        /// <param name="copper">The amount of copper.</param>
        [JsonConstructor]
        public Units(long gold, int silver, int copper)
        {
            Gold = gold;
            Silver = silver;
            Copper = copper;
        }
    }
}
