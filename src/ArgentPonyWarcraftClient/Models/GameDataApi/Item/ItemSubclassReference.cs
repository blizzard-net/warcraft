using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A reference to an item subclass.
    /// </summary>
    public class ItemSubclassReference
    {
        /// <summary>
        /// Gets the key for the item subclass.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the item subclass.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the item subclass.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
