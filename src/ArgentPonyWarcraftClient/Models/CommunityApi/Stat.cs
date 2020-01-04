using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A stat.
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// Gets or sets the stat ID.
        /// </summary>
        [JsonProperty("stat")]
        public int StatId { get; set; }

        /// <summary>
        /// Gets or sets the stat amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
