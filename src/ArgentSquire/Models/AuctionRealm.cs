using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A realm.
    /// </summary>
    public class AuctionRealm
    {
        /// <summary>
        /// Gets or sets the realm name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the realm slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
