using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the pet ability.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the battle pet type for this pet ability.
        /// </summary>
        [JsonProperty("battle_pet_type")]
        public BattlePetType BattlePetType { get; set; }

        /// <summary>
        /// Gets the number of rounds for the pet ability cooldown.
        /// </summary>
        [JsonProperty("rounds")]
        public long Rounds { get; set; }

        /// <summary>
        /// Gets the media associated with this pet ability.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }
    }
}
