using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Progression information for a boss.
    /// </summary>
    public class ProgressionBoss
    {
        /// <summary>
        /// Gets or sets the boss ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the boss name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of kills in Normal mode.
        /// </summary>
        [JsonProperty("normalKills")]
        public int? NormalKills { get; set; }

        /// <summary>
        /// Gets or sets the timestamp for Normal mode.
        /// </summary>
        [JsonProperty("normalTimestamp")]
        public DateTime? NormalTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the number of kills in Heroic mode.
        /// </summary>
        [JsonProperty("heroicKills")]
        public int? HeroicKills { get; set; }

        /// <summary>
        /// Gets or sets the timestamp for Heroic mode.
        /// </summary>
        [JsonProperty("heroicTimestamp")]
        public DateTime? HeroicTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the number of kills in LFR mode.
        /// </summary>
        [JsonProperty("lfrKills")]
        public int? LfrKills { get; set; }

        /// <summary>
        /// Gets or sets the timestamp for LFR mode.
        /// </summary>
        [JsonProperty("lfrTimestamp")]
        public DateTime? LfrTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the number of kills in Mythic mode.
        /// </summary>
        [JsonProperty("mythicKills")]
        public int? MythicKills { get; set; }

        /// <summary>
        /// Gets or sets the timestamp for Mythic mode.
        /// </summary>
        [JsonProperty("mythicTimestamp")]
        public DateTime? MythicTimestamp { get; set; }
    }
}
