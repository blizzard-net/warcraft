using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// An appearance.
    /// </summary>
    public class Appearance
    {
        /// <summary>
        /// Gets or sets the enchant display info ID.
        /// </summary>
        [JsonProperty("enchantDisplayInfoId")]
        public int EnchantDisplayInfoId { get; set; }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the item appearance modifier ID.
        /// </summary>
        [JsonProperty("itemAppearanceModId")]
        public int ItemAppearanceModId { get; set; }
    }
}
