using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of mounts.
    /// </summary>
    public class MountList
    {
        /// <summary>
        /// Gets or sets the list of possible mounts.
        /// </summary>
        [JsonProperty("mounts")]
        public IList<Mount> Mounts { get; set; }
    }
}
