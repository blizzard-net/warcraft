using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A guild.
    /// </summary>
    public class Guild
    {
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
        /// Gets or sets the number of members in the guild.
        /// </summary>
        [JsonProperty("members")]
        public int Members { get; set; }

        /// <summary>
        /// Gets or sets the number of achievement points for the guild.
        /// </summary>
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; set; }

        /// <summary>
        /// Gets or sets the guild emblem.
        /// </summary>
        [JsonProperty("emblem")]
        public Emblem Emblem { get; set; }
    }
}
