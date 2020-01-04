using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// An NPC.
    /// </summary>
    public class Npc
    {
        /// <summary>
        /// Gets the creature display ID.
        /// </summary>
        [JsonProperty(PropertyName = "creatureDisplayId")]
        public int CreatureDisplayId { get; private set; }

        /// <summary>
        /// Gets the NPC ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the URL slug.
        /// </summary>
        [JsonProperty(PropertyName = "urlSlug")]
        public string UrlSlug { get; private set; }
    }
}
