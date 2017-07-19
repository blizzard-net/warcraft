using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A battlegroup.
    /// </summary>
    public class Battlegroup
    {
        /// <summary>
        /// Gets or sets the battlegroup name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
