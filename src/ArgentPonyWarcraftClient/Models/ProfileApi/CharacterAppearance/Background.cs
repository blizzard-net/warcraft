using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A background.
    /// </summary>
    public class Background
    {
        /// <summary>
        /// Gets the background color.
        /// </summary>
        [JsonProperty("color")]
        public Color Color { get; set; }
    }
}
