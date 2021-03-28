using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reputation tier.
    /// </summary>
    public record ReputationTier
    {
        /// <summary>
        /// Gets the name of the reputation tier.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the minimum value of the reputation tier.
        /// </summary>
        [JsonPropertyName("min_value")]
        public int MinValue { get; }

        /// <summary>
        /// Gets the maximum value of the reputation tier.
        /// </summary>
        [JsonPropertyName("max_value")]
        public int MaxValue { get; }

        /// <summary>
        /// Gets the ID of the reputation tier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationTier"/> class.
        /// </summary>
        /// <param name="name">The name of the reputation tier.</param>
        /// <param name="minValue">The minimum value of the reputation tier.</param>
        /// <param name="maxValue">The maximum value of the reputation tier.</param>
        /// <param name="id">The ID of the reputation tier.</param>
        [JsonConstructor]
        public ReputationTier(string name, int minValue, int maxValue, int id)
        {
            Name = name;
            MinValue = minValue;
            MaxValue = maxValue;
            Id = id;
        }
    }
}
