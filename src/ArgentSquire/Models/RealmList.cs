using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A list of realm statuses.
    /// </summary>
    public class RealmList
    {
        /// <summary>
        /// Gets or sets the realms.
        /// </summary>
        [JsonProperty("realms")]
        public IList<Realm> Realms { get; set; }
    }
}
