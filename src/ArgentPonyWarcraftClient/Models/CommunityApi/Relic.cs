using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A relic.
    /// </summary>
    public class Relic
    {
        /// <summary>
        /// Gets or sets the socket.
        /// </summary>
        [JsonProperty("socket")]
        public int Socket { get; set; }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonProperty("context")]
        public int Context { get; set; }

        /// <summary>
        /// Gets or sets the bonus lists.
        /// </summary>
        [JsonProperty("bonusLists")]
        public IList<int> BonusLists { get; set; }
    }
}
