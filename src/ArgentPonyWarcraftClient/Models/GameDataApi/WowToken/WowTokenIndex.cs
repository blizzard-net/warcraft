using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A WoW Token index.
    /// </summary>
    public class WowTokenIndex
    {
        /// <summary>
        /// Gets links for the WoW Token index.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the last updated timestamp for the WoW Token index.
        /// </summary>
        [JsonProperty("last_updated_timestamp")]
        public DateTime LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Gets the price for a Wow token.
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }
    }
}
