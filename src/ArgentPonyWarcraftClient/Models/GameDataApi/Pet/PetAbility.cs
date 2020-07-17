using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A battle pet ability.
    /// </summary>
    public class PetAbility
    {
        /// <summary>
        /// Gets links for the pet ability.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the pet ability.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the battle pet type for this pet ability.
        /// </summary>
        [JsonPropertyName("battle_pet_type")]
        public BattlePetType BattlePetType { get; set; }

        /// <summary>
        /// Gets the number of rounds for the pet ability cooldown.
        /// </summary>
        [JsonPropertyName("rounds")]
        public long Rounds { get; set; }

        /// <summary>
        /// Gets the media associated with this pet ability.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }
    }
}
