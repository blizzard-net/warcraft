using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A reference to a boss encounter in a dungeon or raid.
    /// </summary>
    public class EncounterReference
    {
        /// <summary>
        /// Gets the key for the encounter.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the encounter.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the encounter.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
