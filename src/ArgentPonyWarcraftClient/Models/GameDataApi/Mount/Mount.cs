using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mount.
    /// </summary>
    public partial class Mount
    {
        /// <summary>
        /// Gets links for the mount.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mount.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the mount.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the creature displays media for the mount.
        /// </summary>
        [JsonProperty("creature_displays")]
        public Media[] CreatureDisplays { get; set; }

        /// <summary>
        /// Gets the description of the mount.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the source for where the mount is acquired.
        /// </summary>
        [JsonProperty("source")]
        public EnumType Source { get; set; }

        /// <summary>
        /// Gets the faction for the mount.
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }
    }
}
