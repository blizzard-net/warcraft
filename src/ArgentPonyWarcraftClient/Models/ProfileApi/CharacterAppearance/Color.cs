using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A color.
    /// </summary>
    public class Color
    {
        /// <summary>
        /// Gets the ID of the color.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the RGBA color information.
        /// </summary>
        [JsonProperty("rgba")]
        public ColorDetails Rgba { get; set; }
    }
}
