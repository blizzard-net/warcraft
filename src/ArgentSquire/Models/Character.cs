using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArgentSquire
{
    /// <summary>
    /// A character.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Gets or sets the achievement points.
        /// </summary>
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        /// <summary>
        /// Gets or sets the battlegroup.
        /// </summary>
        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }

        /// <summary>
        /// Gets or sets the calculated class.
        /// </summary>
        [JsonProperty("calcClass")]
        public string CalcClass { get; set; }

        /// <summary>
        /// Gets or sets the character class.
        /// </summary>
        [JsonProperty("class")]
        public int Class { get; set; }

        /// <summary>
        /// Gets or sets the faction.
        /// </summary>
        [JsonProperty("faction")]
        public int Faction { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [JsonProperty("gender")]
        public int Gender { get; set; }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        [JsonProperty("race")]
        public int Race { get; set; }

        /// <summary>
        /// Gets or sets the realm.
        /// </summary>
        [JsonProperty("realm")]
        public string Realm { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the total honorable kills.
        /// </summary>
        [JsonProperty("totalHonorableKills")]
        public int TotalHonorableKills { get; set; }
    }
}