using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// An auction.
    /// </summary>
    public class Auction
    {
        /// <summary>
        /// Gets or sets the auction files.
        /// </summary>
        [JsonProperty("files")]
        public IList<AuctionFile> Files { get; set; }
    }
}
