using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mount.
    /// </summary>
    public class Mount
    {
        /// <summary>
        /// Gets links for the mount.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mount.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the mount.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the creature displays media for the mount.
        /// </summary>
        [JsonPropertyName("creature_displays")]
        public Media[] CreatureDisplays { get; set; }

        /// <summary>
        /// Gets the description of the mount.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the source for where the mount is acquired.
        /// </summary>
        [JsonPropertyName("source")]
        public EnumType Source { get; set; }

        /// <summary>
        /// Gets the faction for the mount.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }
    }
}
