using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of zones.
    /// </summary>
    public class ZoneList
    {
        /// <summary>
        /// Gets or sets the zones.
        /// </summary>
        [JsonProperty("zones")]
        public IList<Zone> Zones { get; set; }
    }
}
