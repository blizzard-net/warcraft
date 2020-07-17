using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A realm.
    /// </summary>
    public class Realm
    {
        /// <summary>
        /// Gets links for the realm.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the region to which this realm belongs.
        /// </summary>
        [JsonPropertyName("region")]
        public RegionReference Region { get; set; }

        /// <summary>
        /// Gets a reference to the connected realm.
        /// </summary>
        [JsonPropertyName("connected_realm")]
        public Self ConnectedRealm { get; set; }

        /// <summary>
        /// Gets the name of the realm.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the category of the realm.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets the locale of the realm.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets the time zone for the realm.
        /// </summary>
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets the realm type.
        /// </summary>
        [JsonPropertyName("type")]
        public EnumType Type { get; set; }

        /// <summary>
        /// Gets a value indicating whether this is a tournament realm.
        /// </summary>
        [JsonPropertyName("is_tournament")]
        public bool IsTournament { get; set; }

        /// <summary>
        /// Gets the slug for the realm.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }
}
