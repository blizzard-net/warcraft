using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A battle pet ability.
    /// </summary>
    public record PetAbility
    {
        /// <summary>
        /// Gets links for the pet ability.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the pet ability.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the battle pet type for this pet ability.
        /// </summary>
        [JsonPropertyName("battle_pet_type")]
        public BattlePetType BattlePetType { get; }

        /// <summary>
        /// Gets the number of rounds for the pet ability cooldown.
        /// </summary>
        [JsonPropertyName("rounds")]
        public int Rounds { get; }

        /// <summary>
        /// Gets the media associated with this pet ability.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetAbility"/> class.
        /// </summary>
        /// <param name="links">Links for the pet ability.</param>
        /// <param name="id">The ID of the pet ability.</param>
        /// <param name="name">The name of the pet ability.</param>
        /// <param name="battlePetType">The battle pet type for this pet ability.</param>
        /// <param name="rounds">The number of rounds for the pet ability cooldown.</param>
        /// <param name="media">The media associated with this pet ability.</param>
        [JsonConstructor]
        public PetAbility(Links links, int id, string name, BattlePetType battlePetType, int rounds, Media media)
        {
            Links = links;
            Id = id;
            Name = name;
            BattlePetType = battlePetType;
            Rounds = rounds;
            Media = media;
        }
    }
}
