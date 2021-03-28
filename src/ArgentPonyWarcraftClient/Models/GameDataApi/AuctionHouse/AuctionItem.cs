using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An auction item.
    /// </summary>
    public record AuctionItem
    {
        /// <summary>
        /// Gets the ID of the auction item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the contex for the item.
        /// </summary>
        [JsonPropertyName("context")]
        public int? Context { get; }

        /// <summary>
        /// Gets the bonus lists for the item.
        /// </summary>
        [JsonPropertyName("bonus_lists")]
        public int[] BonusLists { get; }

        /// <summary>
        /// Gets the modifiers for the item.
        /// </summary>
        [JsonPropertyName("modifiers")]
        public Modifier[] Modifiers { get; }

        /// <summary>
        /// Gets the ID of the pet breed, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_breed_id")]
        public int? PetBreedId { get; }

        /// <summary>
        /// Gets the pet level, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_level")]
        public int? PetLevel { get; }

        /// <summary>
        /// Gets the ID of the pet quality ID, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_quality_id")]
        public int? PetQualityId { get; }

        /// <summary>
        /// Gets the ID of the pet species ID, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_species_id")]
        public int? PetSpeciesId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionItem"/> class.
        /// </summary>
        /// <param name="id">The ID of the auction item.</param>
        /// <param name="context">The contex for the item.</param>
        /// <param name="bonusLists">The bonus lists for the item.</param>
        /// <param name="modifiers">The modifiers for the item.</param>
        /// <param name="petBreedId">The ID of the pet breed, if the item is a pet.</param>
        /// <param name="petLevel">The pet level, if the item is a pet.</param>
        /// <param name="petQualityId">The ID of the pet quality ID, if the item is a pet.</param>
        /// <param name="petSpeciesId">The ID of the pet species ID, if the item is a pet.</param>
        [JsonConstructor]
        public AuctionItem(int id, int? context, int[] bonusLists, Modifier[] modifiers, int? petBreedId, int? petLevel, int? petQualityId, int? petSpeciesId)
        {
            Id = id;
            Context = context;
            BonusLists = bonusLists;
            Modifiers = modifiers;
            PetBreedId = petBreedId;
            PetLevel = petLevel;
            PetQualityId = petQualityId;
            PetSpeciesId = petSpeciesId;
        }
    }
}
