using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Level requirements for an item.
    /// </summary>
    public class Requirements
    {
        /// <summary>
        /// Gets the required level for using an item.
        /// </summary>
        [JsonProperty("level")]
        public DescribedValue Level { get; set; }
    }
}
