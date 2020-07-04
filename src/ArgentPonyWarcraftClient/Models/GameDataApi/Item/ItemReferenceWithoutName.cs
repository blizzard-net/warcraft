using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to an item.
    /// </summary>
    public class ItemReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the item.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the item.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
