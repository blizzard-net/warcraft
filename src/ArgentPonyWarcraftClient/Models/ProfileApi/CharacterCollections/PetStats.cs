using System.Text.Json.Serialization;

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
        [JsonPropertyName("breed_id")]
        public int BreedId { get; set; }

        /// <summary>
        /// Gets the health of the pet.
        /// </summary>
        [JsonPropertyName("health")]
        public int Health { get; set; }

        /// <summary>
        /// Gets the power of the pet.
        /// </summary>
        [JsonPropertyName("power")]
        public int Power { get; set; }

        /// <summary>
        /// Gets the speed of the pet.
        /// </summary>
        [JsonPropertyName("speed")]
        public int Speed { get; set; }
    }
}
