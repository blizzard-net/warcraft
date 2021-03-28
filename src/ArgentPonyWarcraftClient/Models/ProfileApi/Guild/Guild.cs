using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild.
    /// </summary>
    public record Guild
    {
        /// <summary>
        /// Gets links for the guild.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the guild.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the guild.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the guild's faction (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Gets the guild achievement points.
        /// </summary>
        [JsonPropertyName("achievement_points")]
        public int AchievementPoints { get; }

        /// <summary>
        /// Gets the number of members in the guild.
        /// </summary>
        [JsonPropertyName("member_count")]
        public int MemberCount { get; }

        /// <summary>
        /// Gets a reference to the guild's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; }

        /// <summary>
        /// Gets the guild crest.
        /// </summary>
        [JsonPropertyName("crest")]
        public GuildCrest Crest { get; }

        /// <summary>
        /// Gets a link to the guild roster.
        /// </summary>
        [JsonPropertyName("roster")]
        public Self Roster { get; }

        /// <summary>
        /// Gets a link to the guild achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public Self Achievements { get; }

        /// <summary>
        /// Gets the timestamp when the guild was created.
        /// </summary>
        [JsonPropertyName("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; }

        /// <summary>
        /// Gets a link to the guild activity.
        /// </summary>
        [JsonPropertyName("activity")]
        public Self Activity { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guild"/> class.
        /// </summary>
        /// <param name="links">Links for the guild.</param>
        /// <param name="id">The ID of the guild.</param>
        /// <param name="name">The name of the guild.</param>
        /// <param name="faction">The guild's faction (Alliance or Horde).</param>
        /// <param name="achievementPoints">The guild achievement points.</param>
        /// <param name="memberCount">The number of members in the guild.</param>
        /// <param name="realm">A reference to the guild's realm.</param>
        /// <param name="crest">The guild crest.</param>
        /// <param name="roster">A link to the guild roster.</param>
        /// <param name="achievements">A link to the guild achievements.</param>
        /// <param name="createdTimestamp">The timestamp when the guild was created.</param>
        /// <param name="activity">A link to the guild activity.</param>
        [JsonConstructor]
        public Guild(Links links, int id, string name, EnumType faction, int achievementPoints, int memberCount, RealmReference realm, GuildCrest crest, Self roster, Self achievements, DateTimeOffset createdTimestamp, Self activity)
        {
            Links = links;
            Id = id;
            Name = name;
            Faction = faction;
            AchievementPoints = achievementPoints;
            MemberCount = memberCount;
            Realm = realm;
            Crest = crest;
            Roster = roster;
            Achievements = achievements;
            CreatedTimestamp = createdTimestamp;
            Activity = activity;
        }
    }
}
