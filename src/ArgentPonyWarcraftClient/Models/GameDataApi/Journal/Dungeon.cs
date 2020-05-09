using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A dungeon.
    /// </summary>
    public partial class Dungeon
    {
        /// <summary>
        /// Gets the key for the dungeon.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the dungeon.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the dungeon.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
