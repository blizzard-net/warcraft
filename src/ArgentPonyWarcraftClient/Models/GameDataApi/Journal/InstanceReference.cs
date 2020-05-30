using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a dungeon or raid.
    /// </summary>
    public class InstanceReference
    {
        /// <summary>
        /// Gets the key for the instance.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the instance.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
