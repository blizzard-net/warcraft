using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A pet.
    /// </summary>
    public record Pet
    {
        /// <summary>
        /// Gets links for the pet.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the pet.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the battle pet type.
        /// </summary>
        [JsonPropertyName("battle_pet_type")]
        public BattlePetType BattlePetType { get; }

        /// <summary>
        /// Gets a description of the pet.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets a value indicating whether the pet can be captured by a player.
        /// </summary>
        [JsonPropertyName("is_capturable")]
        public bool IsCapturable { get; }

        /// <summary>
        /// Gets a value indicating whether the pet can be traded to another player.
        /// </summary>
        [JsonPropertyName("is_tradable")]
        public bool IsTradable { get; }

        /// <summary>
        /// Gets a value indicating whether the pet can participate in pet battles.
        /// </summary>
        [JsonPropertyName("is_battlepet")]
        public bool IsBattlePet { get; }

        /// <summary>
        /// Gets a value indicating whether the pet is only available to Alliance players.
        /// </summary>
        [JsonPropertyName("is_alliance_only")]
        public bool IsAllianceOnly { get; }

        /// <summary>
        /// Gets a value indicating whether the pet is only available to Horde players.
        /// </summary>
        [JsonPropertyName("is_horde_only")]
        public bool IsHordeOnly { get; }

        /// <summary>
        /// Gets the pet abilities for this pet.
        /// </summary>
        [JsonPropertyName("abilities")]
        public SpeciesPetAbility[] Abilities { get; }

        /// <summary>
        /// Gets the source where the pet can be acquired.
        /// </summary>
        [JsonPropertyName("source")]
        public EnumType Source { get; }

        /// <summary>
        /// Gets a URI for the pet's icon.
        /// </summary>
        [JsonPropertyName("icon")]
        public Uri Icon { get; }

        /// <summary>
        /// Gets a reference to the creature data for this pet.
        /// </summary>
        [JsonPropertyName("creature")]
        public CreatureReference Creature { get; }

        /// <summary>
        /// Gets a value indicating whether the creature display for this pet is random every time the pet is summoned.
        /// </summary>
        [JsonPropertyName("is_random_creature_display")]
        public bool IsRandomCreatureDisplay { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet"/> class.
        /// </summary>
        /// <param name="links">Links for the pet.</param>
        /// <param name="id">The ID of the pet.</param>
        /// <param name="name">The name of the pet.</param>
        /// <param name="battlePetType">The battle pet type.</param>
        /// <param name="description">A description of the pet.</param>
        /// <param name="isCapturable">A value indicating whether the pet can be captured by a player.</param>
        /// <param name="isTradable">A value indicating whether the pet can be traded to another player.</param>
        /// <param name="isBattlePet">A value indicating whether the pet can participate in pet battles.</param>
        /// <param name="isAllianceOnly">A value indicating whether the pet is only available to Alliance players.</param>
        /// <param name="isHordeOnly">A value indicating whether the pet is only available to Horde players.</param>
        /// <param name="abilities">The pet abilities for this pet.</param>
        /// <param name="source">The source where the pet can be acquired.</param>
        /// <param name="icon">A URI for the pet's icon.</param>
        /// <param name="creature">A reference to the creature data for this pet.</param>
        /// <param name="isRandomCreatureDisplay">A value indicating whether the creature display for this pet is random every time the pet is summoned.</param>
        [JsonConstructor]
        public Pet(Links links, int id, string name, BattlePetType battlePetType, string description, bool isCapturable, bool isTradable, bool isBattlePet, bool isAllianceOnly, bool isHordeOnly, SpeciesPetAbility[] abilities, EnumType source, Uri icon, CreatureReference creature, bool isRandomCreatureDisplay)
        {
            Links = links;
            Id = id;
            Name = name;
            BattlePetType = battlePetType;
            Description = description;
            IsCapturable = isCapturable;
            IsTradable = isTradable;
            IsBattlePet = isBattlePet;
            IsAllianceOnly = isAllianceOnly;
            IsHordeOnly = isHordeOnly;
            Abilities = abilities;
            Source = source;
            Icon = icon;
            Creature = creature;
            IsRandomCreatureDisplay = isRandomCreatureDisplay;
        }
    }
}
