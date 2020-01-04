using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A challenge mode dungeon.
    /// </summary>
    public class Challenge
    {
        /// <summary>
        /// Gets or sets the realm.
        /// </summary>
        [JsonProperty("realm")]
        public Realm Realm { get; set; }

        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        [JsonProperty("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        [JsonProperty("groups")]
        public IList<Group> Groups { get; set; }
    }
}
