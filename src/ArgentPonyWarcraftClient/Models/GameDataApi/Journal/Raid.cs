using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A raid.
    /// </summary>
    public partial class Raid
    {
        /// <summary>
        /// Gets the key for the raid.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the raid.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the raid.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
