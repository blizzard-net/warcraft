using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild.
    /// </summary>
    public class Guild
    {
        /// <summary>
        /// Gets links for the guild.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the guild.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the guild.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the guild's faction (Alliance or Horde).
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the guild achievement points.
        /// </summary>
        [JsonProperty("achievement_points")]
        public long AchievementPoints { get; set; }

        /// <summary>
        /// Gets the number of members in the guild.
        /// </summary>
        [JsonProperty("member_count")]
        public long MemberCount { get; set; }

        /// <summary>
        /// Gets a reference to the guild's realm.
        /// </summary>
        [JsonProperty("realm")]
        public RealmReference Realm { get; set; }

        /// <summary>
        /// Gets the guild crest.
        /// </summary>
        [JsonProperty("crest")]
        public GuildCrest Crest { get; set; }

        /// <summary>
        /// Gets a link to the guild roster.
        /// </summary>
        [JsonProperty("roster")]
        public Self Roster { get; set; }

        /// <summary>
        /// Gets a link to the guild achievements.
        /// </summary>
        [JsonProperty("achievements")]
        public Self Achievements { get; set; }

        /// <summary>
        /// Gets the timestamp when the guild was created.
        /// </summary>
        [JsonProperty("created_timestamp")]
        public DateTime CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets a link to the guild activity.
        /// </summary>
        [JsonProperty("activity")]
        public Self Activity { get; set; }
    }
}
