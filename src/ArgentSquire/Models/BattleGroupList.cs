using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A list of battlegroups.
    /// </summary>
    public class BattlegroupList
    {
        /// <summary>
        /// Gets or sets the battlegroups.
        /// </summary>
        [JsonProperty("battlegroups")]
        public IList<Battlegroup> Battlegroups { get; set; }
    }
}
