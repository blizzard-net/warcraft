using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A WoW Token index.
    /// </summary>
    public record WowTokenIndex
    {
        /// <summary>
        /// Gets links for the WoW Token index.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the last updated timestamp for the WoW Token index.
        /// </summary>
        [JsonPropertyName("last_updated_timestamp")]
        public DateTimeOffset LastUpdatedTimestamp { get; }

        /// <summary>
        /// Gets the price for a Wow token.
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WowTokenIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the WoW Token index.</param>
        /// <param name="lastUpdatedTimestamp">The last updated timestamp for the WoW Token index.</param>
        /// <param name="price">The price for a Wow token.</param>
        [JsonConstructor]
        public WowTokenIndex(Links links, DateTimeOffset lastUpdatedTimestamp, long price)
        {
            Links = links;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            Price = price;
        }
    }
}
