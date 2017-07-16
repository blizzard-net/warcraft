using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A guild.
    /// </summary>
    public class Guild
    {
        /// <summary>
        /// Gets or sets the last modified timestamp.
        /// </summary>
        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or sets the guild name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the realm.
        /// </summary>
        [JsonProperty("realm")]
        public string Realm { get; set; }

        /// <summary>
        /// Gets or sets the battlegroup.
        /// </summary>
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }

        /// <summary>
        /// Gets or sets the guild level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        [JsonProperty("side")]
        public Faction Side { get; set; }

        /// <summary>
        /// Gets or sets the members of the guild.
        /// </summary>
        [JsonProperty("members")]
        public IList<GuildMember> Members { get; set; }

        /// <summary>
        /// Gets or sets the number of achievement points for the guild.
        /// </summary>
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        /// <summary>
        /// Gets or sets the achievements.
        /// </summary>
        [JsonProperty("achievements")]
        public Achievements Achievements { get; set; }

        /// <summary>
        /// Gets or sets the guild emblem.
        /// </summary>
        [JsonProperty("emblem")]
        public Emblem Emblem { get; set; }

        /// <summary>
        /// Gets or sets the news feed for the guild.
        /// </summary>
        [JsonProperty("news")]
        public IList<News> News { get; set; }

        /// <summary>
        /// Gets or sets the challenge mode dungeon information.
        /// </summary>
        [JsonProperty("challenge")]
        public IList<Challenge> Challenge { get; set; }
    }
}
