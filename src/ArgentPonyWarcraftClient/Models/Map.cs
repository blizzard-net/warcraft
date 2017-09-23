using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A challenge mode dungeon map.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Gets or sets the map ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the map name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets an indicator of whether the map has a challenge mode.
        /// </summary>
        [JsonProperty("hasChallengeMode")]
        public bool HasChallengeMode { get; set; }

        /// <summary>
        /// Gets or sets the time criteria for a bronze rating.
        /// </summary>
        [JsonProperty("bronzeCriteria")]
        public ChallengeTime BronzeCriteria { get; set; }

        /// <summary>
        /// Gets or sets the time criteria for a silverr rating.
        /// </summary>
        [JsonProperty("silverCriteria")]
        public ChallengeTime SilverCriteria { get; set; }

        /// <summary>
        /// Gets or sets the time criteria for a gold rating.
        /// </summary>
        [JsonProperty("goldCriteria")]
        public ChallengeTime GoldCriteria { get; set; }
    }
}
