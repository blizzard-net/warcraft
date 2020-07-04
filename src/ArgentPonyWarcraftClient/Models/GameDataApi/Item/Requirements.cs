using Newtonsoft.Json;

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
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public DescribedValue Level { get; set; }

        /// <summary>
        /// Gets the required faction for using an item.
        /// </summary>
        [JsonProperty("faction", NullValueHandling = NullValueHandling.Ignore)]
        public FactionRequirement Faction { get; set; }
    }
}
