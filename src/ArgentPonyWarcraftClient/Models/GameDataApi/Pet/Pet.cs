using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A pet.
    /// </summary>
    public class Pet
    {
        /// <summary>
        /// Gets links for the pet.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the name of the pet.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the battle pet type.
        /// </summary>
        [JsonPropertyName("battle_pet_type")]
        public BattlePetType BattlePetType { get; set; }

        /// <summary>
        /// Gets a description of the pet.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet can be captured by a player.
        /// </summary>
        [JsonPropertyName("is_capturable")]
        public bool IsCapturable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet can be traded to another player.
        /// </summary>
        [JsonPropertyName("is_tradable")]
        public bool IsTradable { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet can participate in pet battles.
        /// </summary>
        [JsonPropertyName("is_battlepet")]
        public bool IsBattlePet { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is only available to Alliance players.
        /// </summary>
        [JsonPropertyName("is_alliance_only")]
        public bool IsAllianceOnly { get; set; }

        /// <summary>
        /// Gets a value indicating whether the pet is only available to Horde players.
        /// </summary>
        [JsonPropertyName("is_horde_only")]
        public bool IsHordeOnly { get; set; }

        /// <summary>
        /// Gets the pet abilities for this pet.
        /// </summary>
        [JsonPropertyName("abilities")]
        public SpeciesPetAbility[] Abilities { get; set; }

        /// <summary>
        /// Gets the source where the pet can be acquired.
        /// </summary>
        [JsonPropertyName("source")]
        public EnumType Source { get; set; }

        /// <summary>
        /// Gets a URI for the pet's icon.
        /// </summary>
        [JsonPropertyName("icon")]
        public Uri Icon { get; set; }

        /// <summary>
        /// Gets a reference to the creature data for this pet.
        /// </summary>
        [JsonPropertyName("creature")]
        public CreatureReference Creature { get; set; }

        /// <summary>
        /// Gets a value indicating whether the creature display for this pet is random every time the pet is summoned.
        /// </summary>
        [JsonPropertyName("is_random_creature_display")]
        public bool IsRandomCreatureDisplay { get; set; }
    }
}
