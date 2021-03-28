using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Requirements for an item.
    /// </summary>
    public record Requirements
    {
        /// <summary>
        /// Gets the required level for using an item.
        /// </summary>
        [JsonPropertyName("level")]
        public DescribedValue Level { get; }

        /// <summary>
        /// Gets the required faction for using an item.
        /// </summary>
        [JsonPropertyName("faction")]
        public FactionRequirement Faction { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Requirements"/> class.
        /// </summary>
        /// <param name="level">The required level for using an item.</param>
        /// <param name="faction">The required faction for using an item.</param>
        [JsonConstructor]
        public Requirements(DescribedValue level, FactionRequirement faction)
        {
            Level = level;
            Faction = faction;
        }
    }
}
