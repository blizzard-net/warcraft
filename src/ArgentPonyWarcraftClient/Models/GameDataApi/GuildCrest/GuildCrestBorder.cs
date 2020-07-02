namespace ArgentPonyWarcraftClient
{
    using Newtonsoft.Json;

    /// <summary>
    /// A guild crest border.
    /// </summary>
    public class GuildCrestBorder
    {
        /// <summary>
        /// Gets the ID of the border.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the media associated with the border.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }
    }
}
