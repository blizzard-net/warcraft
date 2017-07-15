using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A character.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Gets or sets the achievements.
        /// </summary>
        [JsonProperty("achievements")]
        public CharacterAchievements Achievements { get; set; }

        /// <summary>
        /// Gets or sets the achievement points.
        /// </summary>
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        /// <summary>
        /// Gets or sets the character's appearance.
        /// </summary>
        [JsonProperty("appearance")]
        public CharacterAppearance Appearance { get; set; }

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
        public CharacterClass Class { get; set; }

        /// <summary>
        /// Gets or sets the faction.
        /// </summary>
        [JsonProperty("faction")]
        public Faction Faction { get; set; }

        /// <summary>
        /// Gets or sets the activity feed.
        /// </summary>
        [JsonProperty("feed")]
        public IList<Feed> Feed { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the character's guild.
        /// </summary>
        [JsonProperty("guild")]
        public Guild Guild { get; set; }

        /// <summary>
        /// Gets or sets the hunter pets.
        /// </summary>
        [JsonProperty("hunterPets")]
        public IList<HunterPet> HunterPets { get; set; }

        /// <summary>
        /// Gets or sets the character items.
        /// </summary>
        [JsonProperty("items")]
        public CharacterItems Items { get; set; }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets information about the character's mounts.
        /// </summary>
        [JsonProperty("mounts")]
        public CharacterMounts Mounts { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets information about the character's pets.
        /// </summary>
        [JsonProperty("pets")]
        public CharacterPets Pets { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        [JsonProperty("race")]
        public Race Race { get; set; }

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