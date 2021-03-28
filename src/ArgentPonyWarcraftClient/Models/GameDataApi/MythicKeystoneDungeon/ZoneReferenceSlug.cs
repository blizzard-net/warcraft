using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a zone.
    /// </summary>
    public record ZoneReferenceSlug
    {
        /// <summary>
        /// Gets the slug for the zone.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneReferenceSlug"/> class.
        /// </summary>
        /// <param name="slug">The slug for the zone.</param>
        [JsonConstructor]
        public ZoneReferenceSlug(string slug)
        {
            Slug = slug;
        }
    }
}
