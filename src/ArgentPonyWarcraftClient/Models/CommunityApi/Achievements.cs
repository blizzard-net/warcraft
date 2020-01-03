using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Achievements.
    /// </summary>
    public class Achievements
    {
        /// <summary>
        /// Gets or sets the IDs of the achievements completed by this character.
        /// </summary>
        [JsonProperty("achievementsCompleted")]
        public IList<int> AchievementsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the timestamps of when the achievements were completed.
        /// </summary>
        [JsonProperty("achievementsCompletedTimestamp")]
        public IList<DateTime> AchievementsCompletedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the criteria.
        /// </summary>
        [JsonProperty("criteria")]
        public IList<int> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the criteria quantity.
        /// </summary>
        [JsonProperty("criteriaQuantity")]
        public IList<long> CriteriaQuantity { get; set; }

        /// <summary>
        /// Gets or sets the criteria timestamp.
        /// </summary>
        [JsonProperty("criteriaTimestamp")]
        public IList<DateTime> CriteriaTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the criteria created.
        /// </summary>
        [JsonProperty("criteriaCreated")]
        public IList<long> CriteriaCreated { get; set; }
    }
}
