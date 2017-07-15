using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A realm.
    /// </summary>
    public class Realm
    {
        /// <summary>
        /// Gets or sets the realm type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the population.
        /// </summary>
        [JsonProperty("population")]
        public string Population { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there is a queue to log in to the realm.
        /// </summary>
        [JsonProperty("queue")]
        public bool Queue { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets the realm name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the battlegroup to which the realm belongs.
        /// </summary>
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the slugs of connected realms.
        /// </summary>
        [JsonProperty("connected_realms")]
        public IList<string> ConnectedRealms { get; set; }
    }
}
