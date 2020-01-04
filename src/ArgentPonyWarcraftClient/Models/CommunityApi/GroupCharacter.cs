using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A character in a challenge mode dungeon group.
    /// </summary>
    public class GroupCharacter
    {
        /// <summary>
        /// Gets or sets the character name.
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
        /// Gets or sets the class.
        /// </summary>
        [JsonProperty("class")]
        public CharacterClass Class { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        [JsonProperty("race")]
        public Race Race { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the achievement points.
        /// </summary>
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the spec.
        /// </summary>
        [JsonProperty("spec")]
        public Spec Spec { get; set; }

        /// <summary>
        /// Gets or sets the guild name.
        /// </summary>
        [JsonProperty("guild")]
        public string Guild { get; set; }

        /// <summary>
        /// Gets or sets the guild realm.
        /// </summary>
        [JsonProperty("guildRealm")]
        public string GuildRealm { get; set; }

        /// <summary>
        /// Gets or sets the last modified timestamp.
        /// </summary>
        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }
    }
}
