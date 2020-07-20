using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a realm.
    /// </summary>
    public class RealmReferenceWithoutKey
    {
        /// <summary>
        /// Gets the name of the realm.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a slug for the realm.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }
}
