using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A pet.
    /// </summary>
    public class Pet
    {
        /// <summary>
        /// Gets or sets the pet name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the spell ID.
        /// </summary>
        [JsonProperty("spellId")]
        public int SpellId { get; set; }

        /// <summary>
        /// Gets or sets the creature ID.
        /// </summary>
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the quality ID.
        /// </summary>
        [JsonProperty("qualityId")]
        public int QualityId { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        [JsonProperty("stats")]
        public PetStats Stats { get; set; }

        /// <summary>
        /// Gets or sets the battle pet GUID.
        /// </summary>
        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this pet is a favorite.
        /// </summary>
        [JsonProperty("isFavorite")]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the first ability slot is selected.
        /// </summary>
        [JsonProperty("isFirstAbilitySlotSelected")]
        public bool IsFirstAbilitySlotSelected { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the second ability slot is selected.
        /// </summary>
        [JsonProperty("isSecondAbilitySlotSelected")]
        public bool IsSecondAbilitySlotSelected { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the third ability slot is selected.
        /// </summary>
        [JsonProperty("isThirdAbilitySlotSelected")]
        public bool IsThirdAbilitySlotSelected { get; set; }

        /// <summary>
        /// Gets or sets the creature name.
        /// </summary>
        [JsonProperty("creatureName")]
        public string CreatureName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the pet can battle.
        /// </summary>
        [JsonProperty("canBattle")]
        public bool CanBattle { get; set; }
    }
}
