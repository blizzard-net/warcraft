using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A reference to a spell.
    /// </summary>
    public class SpellReference
    {
        /// <summary>
        /// Gets the key for the spell.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the spell.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
