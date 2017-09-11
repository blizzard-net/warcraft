using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A list of guild rewards.
    /// </summary>
    public class GuildRewardsList
    {
        /// <summary>
        /// Gets or sets the guild rewards.
        /// </summary>
        [JsonProperty("rewards")]
        public IList<Reward> Rewards { get; set; }
    }
}
