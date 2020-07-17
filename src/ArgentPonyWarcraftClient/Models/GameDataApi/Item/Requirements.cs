using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Requirements for an item.
    /// </summary>
    public class Requirements
    {
        /// <summary>
        /// Gets the required level for using an item.
        /// </summary>
        [JsonPropertyName("level")]
        public DescribedValue Level { get; set; }

        /// <summary>
        /// Gets the required faction for using an item.
        /// </summary>
        [JsonPropertyName("faction")]
        public FactionRequirement Faction { get; set; }
    }
}
