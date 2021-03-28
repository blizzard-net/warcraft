using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item set.
    /// </summary>
    public record ItemSet
    {
        /// <summary>
        /// Gets links for the item set.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the item set.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the item set.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets references to the items in the item set.
        /// </summary>
        [JsonPropertyName("items")]
        public ItemReference[] Items { get; }

        /// <summary>
        /// Gets the item set bonuses.
        /// </summary>
        [JsonPropertyName("effects")]
        public Effect[] Effects { get; }

        /// <summary>
        /// Gets a value indicating whether the effect is active.
        /// </summary>
        [JsonPropertyName("is_effect_active")]
        public bool IsEffectActive { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSet"/> class.
        /// </summary>
        /// <param name="links">Links for the item set.</param>
        /// <param name="id">The ID of the item set.</param>
        /// <param name="name">The name of the item set.</param>
        /// <param name="items">References to the items in the item set.</param>
        /// <param name="effects">The item set bonuses.</param>
        /// <param name="isEffectActive">A value indicating whether the effect is active.</param>
        [JsonConstructor]
        public ItemSet(Links links, int id, string name, ItemReference[] items, Effect[] effects, bool isEffectActive)
        {
            Links = links;
            Id = id;
            Name = name;
            Items = items;
            Effects = effects;
            IsEffectActive = isEffectActive;
        }
    }
}
