using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a realm.
    /// </summary>
    public record RealmReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the realm.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a slug for the realm.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealmReferenceWithoutName"/> class.
        /// </summary>
        /// <param name="key">The key for the realm.</param>
        /// <param name="id">The ID of the realm.</param>
        /// <param name="slug">A slug for the realm.</param>
        [JsonConstructor]
        public RealmReferenceWithoutName(Self key, int id, string slug)
        {
            Key = key;
            Id = id;
            Slug = slug;
        }
    }
}
