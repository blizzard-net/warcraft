using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A challenge mode group.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Gets or sets the ranking.
        /// </summary>
        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        [JsonProperty("time")]
        public ChallengeTime Time { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the medal.
        /// </summary>
        [JsonProperty("medal")]
        public string Medal { get; set; }

        /// <summary>
        /// Gets or sets the faction.
        /// </summary>
        [JsonProperty("faction")]
        public string Faction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is recurring.
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Gets or sets the group members.
        /// </summary>
        [JsonProperty("members")]
        public IList<GroupMember> Members { get; set; }

        /// <summary>
        /// Gets or sets the guild.
        /// </summary>
        [JsonProperty("guild")]
        public CharacterGuild Guild { get; set; }
    }
}
