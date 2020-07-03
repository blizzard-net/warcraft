using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of power types.
    /// </summary>
    public class PowerTypesIndex
    {
        /// <summary>
        /// Gets links for the index of power types.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the power types.
        /// </summary>
        [JsonProperty("power_types")]
        public PowerTypeReference[] PowerTypes { get; set; }
    }
}
