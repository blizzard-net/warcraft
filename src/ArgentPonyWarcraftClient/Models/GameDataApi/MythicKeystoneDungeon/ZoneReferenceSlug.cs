using System.Text.Json.Serialization;

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
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }
}
