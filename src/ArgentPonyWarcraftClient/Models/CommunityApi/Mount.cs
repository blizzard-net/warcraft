using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A mount.
    /// </summary>
    public class Mount
    {
        /// <summary>
        /// Gets or sets the mount name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the spell ID.
        /// </summary>
        [JsonProperty("spellId")]
        public int SpellId { get; set; }

        /// <summary>
        /// Gets or sets the creature ID.
        /// </summary>
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        [JsonProperty("qualityId")]
        public ItemQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mount is a ground mount.
        /// </summary>
        [JsonProperty("isGround")]
        public bool IsGround { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mount is a flying mount.
        /// </summary>
        [JsonProperty("isFlying")]
        public bool IsFlying { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mount is an aquatic mount.
        /// </summary>
        [JsonProperty("isAquatic")]
        public bool IsAquatic { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mount is a jumping mount.
        /// </summary>
        [JsonProperty("isJumping")]
        public bool IsJumping { get; set; }
    }
}
