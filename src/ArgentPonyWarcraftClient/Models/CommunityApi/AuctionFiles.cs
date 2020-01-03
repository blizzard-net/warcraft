using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An auction files listing.
    /// </summary>
    public class AuctionFiles
    {
        /// <summary>
        /// Gets or sets the auction file summaries.
        /// </summary>
        [JsonProperty("files")]
        public IList<AuctionFileSummary> Files { get; set; }
    }
}
