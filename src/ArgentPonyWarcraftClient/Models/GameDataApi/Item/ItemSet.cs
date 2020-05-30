using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An item set.
    /// </summary>
    public class ItemSet
    {
        /// <summary>
        /// Gets links for the item set.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the item set.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the item set.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets references to the items in the item set.
        /// </summary>
        [JsonProperty("items")]
        public ItemReference[] Items { get; set; }

        /// <summary>
        /// Gets the item set bonuses.
        /// </summary>
        [JsonProperty("effects")]
        public Effect[] Effects { get; set; }

        /// <summary>
        /// Gets a value indicating whether the effect is active.
        /// </summary>
        [JsonProperty("is_effect_active")]
        public bool IsEffectActive { get; set; }
    }
}
