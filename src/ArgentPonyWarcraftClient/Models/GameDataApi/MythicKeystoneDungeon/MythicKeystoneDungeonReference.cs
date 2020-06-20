using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a Mythic Keystone dungeon.
    /// </summary>
    public class MythicKeystoneDungeonReference
    {
        /// <summary>
        /// Gets the key for the Mythic Keystone dungeon.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the Mythic Keystone dungeon.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the Mythic Keystone dungeon.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
