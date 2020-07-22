using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the guild.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the guild.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the guild's faction (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the guild achievement points.
        /// </summary>
        [JsonPropertyName("achievement_points")]
        public int AchievementPoints { get; set; }

        /// <summary>
        /// Gets the number of members in the guild.
        /// </summary>
        [JsonPropertyName("member_count")]
        public int MemberCount { get; set; }

        /// <summary>
        /// Gets a reference to the guild's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; set; }

        /// <summary>
        /// Gets the guild crest.
        /// </summary>
        [JsonPropertyName("crest")]
        public GuildCrest Crest { get; set; }

        /// <summary>
        /// Gets a link to the guild roster.
        /// </summary>
        [JsonPropertyName("roster")]
        public Self Roster { get; set; }

        /// <summary>
        /// Gets a link to the guild achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public Self Achievements { get; set; }

        /// <summary>
        /// Gets the timestamp when the guild was created.
        /// </summary>
        [JsonPropertyName("created_timestamp")]
        public DateTime CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets a link to the guild activity.
        /// </summary>
        [JsonPropertyName("activity")]
        public Self Activity { get; set; }
    }
}
