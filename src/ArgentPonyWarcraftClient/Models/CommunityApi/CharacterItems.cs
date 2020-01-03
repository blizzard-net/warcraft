using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Character items.
    /// </summary>
    public class CharacterItems
    {
        /// <summary>
        /// Gets or sets the average item level.
        /// </summary>
        [JsonProperty("averageItemLevel")]
        public int AverageItemLevel { get; set; }

        /// <summary>
        /// Gets or sets the average item level equipped.
        /// </summary>
        [JsonProperty("averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; set; }

        /// <summary>
        /// Gets or sets the head slot item.
        /// </summary>
        [JsonProperty("head")]
        public CharacterItem Head { get; set; }

        /// <summary>
        /// Gets or sets the neck slot item.
        /// </summary>
        [JsonProperty("neck")]
        public CharacterItem Neck { get; set; }

        /// <summary>
        /// Gets or sets the shoulder slot item.
        /// </summary>
        [JsonProperty("shoulder")]
        public CharacterItem Shoulder { get; set; }

        /// <summary>
        /// Gets or sets the back slot item.
        /// </summary>
        [JsonProperty("back")]
        public CharacterItem Back { get; set; }

        /// <summary>
        /// Gets or sets the chest slot item.
        /// </summary>
        [JsonProperty("chest")]
        public CharacterItem Chest { get; set; }

        /// <summary>
        /// Gets or sets the shirt slot item.
        /// </summary>
        [JsonProperty("shirt")]
        public CharacterItem Shirt { get; set; }

        /// <summary>
        /// Gets or sets the tabard slot item.
        /// </summary>
        [JsonProperty("tabard")]
        public CharacterItem Tabard { get; set; }

        /// <summary>
        /// Gets or sets the wrist slot item.
        /// </summary>
        [JsonProperty("wrist")]
        public CharacterItem Wrist { get; set; }

        /// <summary>
        /// Gets or sets the hands slot item.
        /// </summary>
        [JsonProperty("hands")]
        public CharacterItem Hands { get; set; }

        /// <summary>
        /// Gets or sets the waist slot item.
        /// </summary>
        [JsonProperty("waist")]
        public CharacterItem Waist { get; set; }

        /// <summary>
        /// Gets or sets the legs slot item.
        /// </summary>
        [JsonProperty("legs")]
        public CharacterItem Legs { get; set; }

        /// <summary>
        /// Gets or sets the feet slot item.
        /// </summary>
        [JsonProperty("feet")]
        public CharacterItem Feet { get; set; }

        /// <summary>
        /// Gets or sets the finger 1 slot item.
        /// </summary>
        [JsonProperty("finger1")]
        public CharacterItem Finger1 { get; set; }

        /// <summary>
        /// Gets or sets the finger 2 slot item.
        /// </summary>
        [JsonProperty("finger2")]
        public CharacterItem Finger2 { get; set; }

        /// <summary>
        /// Gets or sets the trinket 1 slot item.
        /// </summary>
        [JsonProperty("trinket1")]
        public CharacterItem Trinket1 { get; set; }

        /// <summary>
        /// Gets or sets the trinket 2 slot item.
        /// </summary>
        [JsonProperty("trinket2")]
        public CharacterItem Trinket2 { get; set; }

        /// <summary>
        /// Gets or sets the main hand slot item.
        /// </summary>
        [JsonProperty("mainHand")]
        public CharacterItem MainHand { get; set; }

        /// <summary>
        /// Gets or sets the off hand slot item.
        /// </summary>
        [JsonProperty("offHand")]
        public CharacterItem OffHand { get; set; }
    }
}
