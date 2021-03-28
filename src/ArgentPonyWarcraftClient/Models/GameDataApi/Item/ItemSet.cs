using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item set.
    /// </summary>
    public class ItemSet
    {
        /// <summary>
        /// Gets links for the item set.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the item set.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the item set.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets references to the items in the item set.
        /// </summary>
        [JsonPropertyName("items")]
        public ItemReference[] Items { get; set; }

        /// <summary>
        /// Gets the item set bonuses.
        /// </summary>
        [JsonPropertyName("effects")]
        public Effect[] Effects { get; set; }

        /// <summary>
        /// Gets a value indicating whether the effect is active.
        /// </summary>
        [JsonPropertyName("is_effect_active")]
        public bool IsEffectActive { get; set; }
    }
}
