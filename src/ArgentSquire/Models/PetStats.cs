using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// Pet stats.
    /// </summary>
    public class PetStats
    {
        /// <summary>
        /// Gets or sets the species ID.
        /// </summary>
        [JsonProperty("speciesId")]
        public int SpeciesId { get; set; }

        /// <summary>
        /// Gets or sets the breed ID.
        /// </summary>
        [JsonProperty("breedId")]
        public int BreedId { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        [JsonProperty("petQualityId")]
        public BattlePetQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the health.
        /// </summary>
        [JsonProperty("health")]
        public int Health { get; set; }

        /// <summary>
        /// Gets or sets the power.
        /// </summary>
        [JsonProperty("power")]
        public int Power { get; set; }

        /// <summary>
        /// Gets or sets the speed.
        /// </summary>
        [JsonProperty("speed")]
        public int Speed { get; set; }
    }
}
