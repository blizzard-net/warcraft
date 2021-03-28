using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a realm.
    /// </summary>
    public record RealmReferenceWithoutKey
    {
        /// <summary>
        /// Gets the name of the realm.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

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
        /// Initializes a new instance of the <see cref="RealmReferenceWithoutKey"/> class.
        /// </summary>
        /// <param name="name">The name of the realm.</param>
        /// <param name="id">The ID of the realm.</param>
        /// <param name="slug">A slug for the realm.</param>
        [JsonConstructor]
        public RealmReferenceWithoutKey(string name, int id, string slug)
        {
            Name = name;
            Id = id;
            Slug = slug;
        }
    }
}
