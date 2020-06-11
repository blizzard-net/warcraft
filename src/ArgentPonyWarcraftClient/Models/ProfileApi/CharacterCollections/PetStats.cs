using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Character pet stats.
    /// </summary>
    public class PetStats
    {
        /// <summary>
        /// Gets the breed ID of the pet.
        /// </summary>
        [JsonProperty("breed_id")]
        public long BreedId { get; set; }

        /// <summary>
        /// Gets the health of the pet.
        /// </summary>
        [JsonProperty("health")]
        public long Health { get; set; }

        /// <summary>
        /// Gets the power of the pet.
        /// </summary>
        [JsonProperty("power")]
        public long Power { get; set; }

        /// <summary>
        /// Gets the speed of the pet.
        /// </summary>
        [JsonProperty("speed")]
        public long Speed { get; set; }
    }
}
