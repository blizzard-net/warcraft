using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// An Azerite-empowered item.
    /// </summary>
    public class AzeriteEmpoweredItem
    {
        /// <summary>
        /// Gets or sets the Azerite powers.
        /// </summary>
        [JsonProperty("azeritePowers")]
        public IList<AzeritePower> AzeritePowers { get; set; }
    }
}
