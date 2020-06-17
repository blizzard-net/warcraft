using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the region to which this realm belongs.
        /// </summary>
        [JsonProperty("region")]
        public RegionReference Region { get; set; }

        /// <summary>
        /// Gets a reference to the connected realm.
        /// </summary>
        [JsonProperty("connected_realm")]
        public Self ConnectedRealm { get; set; }

        /// <summary>
        /// Gets the name of the realm.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the category of the realm.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets the locale of the realm.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets the time zone for the realm.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets the realm type.
        /// </summary>
        [JsonProperty("type")]
        public EnumType Type { get; set; }

        /// <summary>
        /// Gets a value indicating whether this is a tournament realm.
        /// </summary>
        [JsonProperty("is_tournament")]
        public bool IsTournament { get; set; }

        /// <summary>
        /// Gets the slug for the realm.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
