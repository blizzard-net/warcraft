using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
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
        /// Gets the set.
        /// </summary>
        [JsonProperty(PropertyName = "set")]
        public IList<int> Set { get; private set; }

        /// <summary>
        /// Gets the timewalker level.
        /// </summary>
        [JsonProperty(PropertyName = "timewalkerLevel")]
        public int TimewalkerLevel { get; private set; }

        /// <summary>
        /// Gets the Azerite power 0.
        /// </summary>
        [JsonProperty(PropertyName = "azeritePower0")]
        public int AzeritePower0 { get; private set; }

        /// <summary>
        /// Gets the Azerite power 1.
        /// </summary>
        [JsonProperty(PropertyName = "azeritePower1")]
        public int AzeritePower1 { get; private set; }

        /// <summary>
        /// Gets the Azerite power 2.
        /// </summary>
        [JsonProperty(PropertyName = "azeritePower2")]
        public int AzeritePower2 { get; private set; }

        /// <summary>
        /// Gets the Azerite power 3.
        /// </summary>
        [JsonProperty(PropertyName = "azeritePower3")]
        public int AzeritePower3 { get; private set; }

        /// <summary>
        /// Gets the Azerite power 4.
        /// </summary>
        [JsonProperty(PropertyName = "azeritePower4")]
        public int AzeritePower4 { get; private set; }

        /// <summary>
        /// Gets the Azerite power level.
        /// </summary>
        [JsonProperty(PropertyName = "azeritePowerLevel")]
        public int AzeritePowerLevel { get; private set; }
    }
}
