using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item source.
    /// </summary>
    public class ItemSource
    {
        /// <summary>
        /// Gets or sets the source ID.
        /// </summary>
        [JsonProperty("sourceId")]
        public int SourceId { get; set; }

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }
    }
}
