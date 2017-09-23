using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Tooltip parameters.
    /// </summary>
    public class TooltipParams
    {
        /// <summary>
        /// Gets or sets the item ID of the enchantment.
        /// </summary>
        [JsonProperty("enchant")]
        public int Enchant { get; set; }

        /// <summary>
        /// Gets or sets the item ID of the gem in slot 0.
        /// </summary>
        [JsonProperty("gem0")]
        public int Gem0 { get; set; }

        /// <summary>
        /// Gets or sets the item ID of the gem in slot 1.
        /// </summary>
        [JsonProperty("gem1")]
        public int Gem1 { get; set; }

        /// <summary>
        /// Gets or sets the item ID of the gem in slot 2.
        /// </summary>
        [JsonProperty("gem2")]
        public int Gem2 { get; set; }

        /// <summary>
        /// Gets or sets the transmog item ID.
        /// </summary>
        [JsonProperty("transmogItem")]
        public int TransmogItem { get; set; }

        /// <summary>
        /// Gets the timewalker level.
        /// </summary>
        [JsonProperty(PropertyName = "timewalkerLevel")]
        public int TimewalkerLevel { get; private set; }
    }
}
