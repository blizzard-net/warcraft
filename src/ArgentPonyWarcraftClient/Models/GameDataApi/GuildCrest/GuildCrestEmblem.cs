namespace ArgentPonyWarcraftClient
{
    using Newtonsoft.Json;

    /// <summary>
    /// A guild crest emblem.
    /// </summary>
    public class GuildCrestEmblem
    {
        /// <summary>
        /// Gets the ID of the emblem.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the media associated with the emblem.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }
    }
}
