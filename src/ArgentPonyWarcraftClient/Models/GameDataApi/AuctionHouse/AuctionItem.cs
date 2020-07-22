using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An auction item.
    /// </summary>
    public class AuctionItem
    {
        /// <summary>
        /// Gets the ID of the auction item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the contex for the item.
        /// </summary>
        [JsonPropertyName("context")]
        public int? Context { get; set; }

        /// <summary>
        /// Gets the bonus lists for the item.
        /// </summary>
        [JsonPropertyName("bonus_lists")]
        public int[] BonusLists { get; set; }

        /// <summary>
        /// Gets the modifiers for the item.
        /// </summary>
        [JsonPropertyName("modifiers")]
        public Modifier[] Modifiers { get; set; }

        /// <summary>
        /// Gets the ID of the pet breed, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_breed_id")]
        public int? PetBreedId { get; set; }

        /// <summary>
        /// Gets the pet level, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_level")]
        public int? PetLevel { get; set; }

        /// <summary>
        /// Gets the ID of the pet quality ID, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_quality_id")]
        public int? PetQualityId { get; set; }

        /// <summary>
        /// Gets the ID of the pet species ID, if the item is a pet.
        /// </summary>
        [JsonPropertyName("pet_species_id")]
        public int? PetSpeciesId { get; set; }
    }
}
