using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A realm.
    /// </summary>
    public record Realm
    {
        /// <summary>
        /// Gets links for the realm.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the region to which this realm belongs.
        /// </summary>
        [JsonPropertyName("region")]
        public RegionReference Region { get; }

        /// <summary>
        /// Gets a reference to the connected realm.
        /// </summary>
        [JsonPropertyName("connected_realm")]
        public Self ConnectedRealm { get; }

        /// <summary>
        /// Gets the name of the realm.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the category of the realm.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; }

        /// <summary>
        /// Gets the locale of the realm.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; }

        /// <summary>
        /// Gets the time zone for the realm.
        /// </summary>
        [JsonPropertyName("timezone")]
        public string Timezone { get; }

        /// <summary>
        /// Gets the realm type.
        /// </summary>
        [JsonPropertyName("type")]
        public EnumType Type { get; }

        /// <summary>
        /// Gets a value indicating whether this is a tournament realm.
        /// </summary>
        [JsonPropertyName("is_tournament")]
        public bool IsTournament { get; }

        /// <summary>
        /// Gets the slug for the realm.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Realm"/> class.
        /// </summary>
        /// <param name="links">Links for the realm.</param>
        /// <param name="id">The ID of the realm.</param>
        /// <param name="region">A reference to the region to which this realm belongs.</param>
        /// <param name="connectedRealm">A reference to the connected realm.</param>
        /// <param name="name">The name of the realm.</param>
        /// <param name="category">The category of the realm.</param>
        /// <param name="locale">The locale of the realm.</param>
        /// <param name="timezone">The time zone for the realm.</param>
        /// <param name="type">The realm type.</param>
        /// <param name="isTournament">A value indicating whether this is a tournament realm.</param>
        /// <param name="slug">The slug for the realm.</param>
        [JsonConstructor]
        public Realm(Links links, int id, RegionReference region, Self connectedRealm, string name, string category, string locale, string timezone, EnumType type, bool isTournament, string slug)
        {
            Links = links;
            Id = id;
            Region = region;
            ConnectedRealm = connectedRealm;
            Name = name;
            Category = category;
            Locale = locale;
            Timezone = timezone;
            Type = type;
            IsTournament = isTournament;
            Slug = slug;
        }
    }
}
