using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A character in a guild.
    /// </summary>
    public class GuildCharacter
    {
        /// <summary>
        /// Gets or sets the character's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the realm.
        /// </summary>
        [JsonProperty("realm")]
        public string Realm { get; set; }

        /// <summary>
        /// Get or sets the battlegroup.
        /// </summary>
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }

        /// <summary>
        /// Get or sets the character class.
        /// </summary>
        [JsonProperty("class")]
        public CharacterClass Class { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        [JsonProperty("race")]
        public Race Race { get; set; }

        /// <summary>
        /// Get or sets the gender.
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Get or sets the level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Get or sets the achievement points.
        /// </summary>
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        /// <summary>
        /// Get or sets the thumbnail.
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Get or sets the spec.
        /// </summary>
        [JsonProperty("spec")]
        public Spec Spec { get; set; }

        /// <summary>
        /// Get or sets the name of the guild.
        /// </summary>
        [JsonProperty("guild")]
        public string Guild { get; set; }

        /// <summary>
        /// Get or sets the guild realm.
        /// </summary>
        [JsonProperty("guildRealm")]
        public string GuildRealm { get; set; }

        /// <summary>
        /// Get or sets the last modified timestamp.
        /// </summary>
        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }
    }
}
