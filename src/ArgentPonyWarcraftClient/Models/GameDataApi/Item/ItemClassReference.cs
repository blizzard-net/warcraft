using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item class.
    /// </summary>
    public class ItemClassReference
    {
        /// <summary>
        /// Gets the key for the item class.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the item class.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the item class.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
