using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of connected realms.
    /// </summary>
    public class ConnectedRealmsIndex
    {
        /// <summary>
        /// Gets links for the index of connected realms.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the connected realms.
        /// </summary>
        [JsonProperty("connected_realms")]
        public Self[] ConnectedRealms { get; set; }
    }
}
