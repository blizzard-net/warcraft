using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Character pet stats.
    /// </summary>
    public record PetStats
    {
        /// <summary>
        /// Gets the breed ID of the pet.
        /// </summary>
        [JsonPropertyName("breed_id")]
        public int BreedId { get; }

        /// <summary>
        /// Gets the health of the pet.
        /// </summary>
        [JsonPropertyName("health")]
        public int Health { get; }

        /// <summary>
        /// Gets the power of the pet.
        /// </summary>
        [JsonPropertyName("power")]
        public int Power { get; }

        /// <summary>
        /// Gets the speed of the pet.
        /// </summary>
        [JsonPropertyName("speed")]
        public int Speed { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetStats"/> class.
        /// </summary>
        /// <param name="breedId">The breed ID of the pet.</param>
        /// <param name="health">The health of the pet.</param>
        /// <param name="power">The power of the pet.</param>
        /// <param name="speed">The speed of the pet.</param>
        [JsonConstructor]
        public PetStats(int breedId, int health, int power, int speed)
        {
            BreedId = breedId;
            Health = health;
            Power = power;
            Speed = speed;
        }
    }
}
