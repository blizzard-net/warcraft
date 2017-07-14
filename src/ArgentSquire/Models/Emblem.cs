using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// An emblem.
    /// </summary>
    public class Emblem
    {
        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public int Icon { get; set; }

        /// <summary>
        /// Gets or sets the icon color.
        /// </summary>
        [JsonProperty("iconColor")]
        public string IconColor { get; set; }

        /// <summary>
        /// Gets or sets the icon color ID.
        /// </summary>
        [JsonProperty("iconColorId")]
        public int IconColorId { get; set; }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        [JsonProperty("border")]
        public int Border { get; set; }

        /// <summary>
        /// Gets or sets the border color.
        /// </summary>
        [JsonProperty("borderColor")]
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border color ID.
        /// </summary>
        [JsonProperty("borderColorId")]
        public int BorderColorId { get; set; }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the background color ID.
        /// </summary>
        [JsonProperty("backgroundColorId")]
        public int BackgroundColorId { get; set; }
    }
}
