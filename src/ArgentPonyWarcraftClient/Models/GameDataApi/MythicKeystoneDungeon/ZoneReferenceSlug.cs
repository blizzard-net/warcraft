using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a zone.
    /// </summary>
    public class ZoneReferenceSlug
    {
        /// <summary>
        /// Gets the slug for the zone.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
