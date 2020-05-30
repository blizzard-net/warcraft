using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A reference to an item set.
    /// </summary>
    public class ItemSetReference
    {
        /// <summary>
        /// Gets the key for the item set.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the item set.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the item set.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
