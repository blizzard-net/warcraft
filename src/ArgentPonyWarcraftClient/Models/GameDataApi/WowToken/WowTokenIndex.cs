using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the last updated timestamp for the WoW Token index.
        /// </summary>
        [JsonPropertyName("last_updated_timestamp")]
        public DateTime LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Gets the price for a Wow token.
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }
    }
}
