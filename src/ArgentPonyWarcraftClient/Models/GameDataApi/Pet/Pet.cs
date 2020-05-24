using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A pet.
    /// </summary>
    public class Pet
    {
        /// <summary>
        /// Gets links for the pet.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the pet.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the battle pet type.
        /// </summary>
        [JsonProperty("battle_pet_type")]
        public BattlePetType BattlePetType { get; set; }

        /// <summary>
        /// Gets a description of the pet.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet can be captured by a player.
        /// </summary>
        [JsonProperty("is_capturable")]
        public bool IsCapturable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet can be traded to another player.
        /// </summary>
        [JsonProperty("is_tradable")]
        public bool IsTradable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet can participate in pet battles.
        /// </summary>
        [JsonProperty("is_battlepet")]
        public bool IsBattlePet { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is only available to Alliance players.
        /// </summary>
        [JsonProperty("is_alliance_only")]
        public bool IsAllianceOnly { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is only available to Horde players.
        /// </summary>
        [JsonProperty("is_horde_only")]
        public bool IsHordeOnly { get; set; }

        /// <summary>
        /// Gets the pet abilities for this pet.
        /// </summary>
        [JsonProperty("abilities")]
        public SpeciesPetAbility[] Abilities { get; set; }

        /// <summary>
        /// Gets the source where the pet can be acquired.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// Gets a URI for the pet's icon.
        /// </summary>
        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        /// <summary>
        /// Gets a reference to the creature data for this pet.
        /// </summary>
        [JsonProperty("creature")]
        public CreatureReference Creature { get; set; }

        /// <summary>
        /// Gets a value indicating whether the creature display for this pet is random every time the pet is summoned.
        /// </summary>
        [JsonProperty("is_random_creature_display")]
        public bool IsRandomCreatureDisplay { get; set; }
    }
}
