using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// An achievement.
    /// </summary>
    public class Achievement
    {
        /// <summary>
        /// Gets a value indicating whether the achievement is account-wide.
        /// </summary>
        [JsonProperty(PropertyName = "accountWide")]
        public bool AccountWide { get; private set; }

        /// <summary>
        /// Gets the achievement criteria.
        /// </summary>
        [JsonProperty(PropertyName = "criteria")]
        public List<Criterion> Criteria { get; private set; }

        /// <summary>
        /// Gets the achievement description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the faction ID.
        /// </summary>
        [JsonProperty(PropertyName = "factionId")]
        public int FactionId { get; private set; }

        /// <summary>
        /// Gets the name of the icon for the achievement.
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; private set; }

        /// <summary>
        /// Gets the achievement ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the number of achievement points for this achievement.
        /// </summary>
        [JsonProperty(PropertyName = "points")]
        public int Points { get; private set; }

        /// <summary>
        /// Gets the name of the achievement reward.
        /// </summary>
        [JsonProperty(PropertyName = "reward")]
        public string Reward { get; private set; }

        /// <summary>
        /// Gets the reward items.
        /// </summary>
        [JsonProperty(PropertyName = "rewardItems")]
        public List<RewardItem> RewardItems { get; private set; }

        /// <summary>
        /// Gets the achievement title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }
    }
}
