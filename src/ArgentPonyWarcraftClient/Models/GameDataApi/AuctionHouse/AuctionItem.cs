using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An auction item.
    /// </summary>
    public class AuctionItem
    {
        /// <summary>
        /// Gets the ID of the auction item.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the contex for the item.
        /// </summary>
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public long? Context { get; set; }

        /// <summary>
        /// Gets the bonus lists for the item.
        /// </summary>
        [JsonProperty("bonus_lists", NullValueHandling = NullValueHandling.Ignore)]
        public long[] BonusLists { get; set; }

        /// <summary>
        /// Gets the modifiers for the item.
        /// </summary>
        [JsonProperty("modifiers", NullValueHandling = NullValueHandling.Ignore)]
        public Modifier[] Modifiers { get; set; }

        /// <summary>
        /// Gets the ID of the pet breed, if the item is a pet.
        /// </summary>
        [JsonProperty("pet_breed_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? PetBreedId { get; set; }

        /// <summary>
        /// Gets the pet level, if the item is a pet.
        /// </summary>
        [JsonProperty("pet_level", NullValueHandling = NullValueHandling.Ignore)]
        public long? PetLevel { get; set; }

        /// <summary>
        /// Gets the ID of the pet quality ID, if the item is a pet.
        /// </summary>
        [JsonProperty("pet_quality_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? PetQualityId { get; set; }

        /// <summary>
        /// Gets the ID of the pet species ID, if the item is a pet.
        /// </summary>
        [JsonProperty("pet_species_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? PetSpeciesId { get; set; }
    }
}
