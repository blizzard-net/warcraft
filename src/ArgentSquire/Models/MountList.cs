using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    public class MountList
    {
        /// <summary>
        /// Gets or sets the list of possible mounts.
        /// </summary>
        [JsonProperty("mounts")]
        public IList<Mount> Mounts { get; set; }
    }
}
