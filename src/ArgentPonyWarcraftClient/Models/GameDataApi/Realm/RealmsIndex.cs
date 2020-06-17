using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of realms.
    /// </summary>
    public class RealmsIndex
    {
        /// <summary>
        /// Gets links for the index of realms.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the realms.
        /// </summary>
        [JsonProperty("realms")]
        public RealmReference[] Realms { get; set; }
    }
}
