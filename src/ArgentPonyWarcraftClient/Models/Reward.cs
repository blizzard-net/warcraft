using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild reward.
    /// </summary>
    public class Reward
    {
        /// <summary>
        /// Gets or sets the minimum guild level.
        /// </summary>
        [JsonProperty("minGuildLevel")]
        public int MinGuildLevel { get; set; }

        /// <summary>
        /// Gets or sets the minimum guild reputation level.
        /// </summary>
        [JsonProperty("minGuildRepLevel")]
        public int MinGuildRepLevel { get; set; }

        /// <summary>
        /// Gets or sets the achievement associated with the reward.
        /// </summary>
        [JsonProperty("achievement")]
        public Achievement Achievement { get; set; }

        /// <summary>
        /// Gets or sets the reward item.
        /// </summary>
        [JsonProperty("item")]
        public CharacterItem Item { get; set; }

        /// <summary>
        /// Gets or sets the races.
        /// </summary>
        [JsonProperty("races")]
        public IList<Race> Races { get; set; }
    }
}
