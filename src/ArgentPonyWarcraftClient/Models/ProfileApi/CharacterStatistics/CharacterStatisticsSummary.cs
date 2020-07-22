using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A statistics summary for a character.
    /// </summary>
    public class CharacterStatisticsSummary
    {
        /// <summary>
        /// Gets links for the statistics summary for the character.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the character's health.
        /// </summary>
        [JsonPropertyName("health")]
        public int Health { get; set; }

        /// <summary>
        /// Gets the character's power.
        /// </summary>
        [JsonPropertyName("power")]
        public int Power { get; set; }

        /// <summary>
        /// Gets a reference to the character's power type.
        /// </summary>
        [JsonPropertyName("power_type")]
        public PowerTypeReference PowerType { get; set; }

        /// <summary>
        /// Gets the character's speed.
        /// </summary>
        [JsonPropertyName("speed")]
        public RatingStatisticWithoutValue Speed { get; set; }

        /// <summary>
        /// Gets the character's strength.
        /// </summary>
        [JsonPropertyName("strength")]
        public PrimaryStatistic Strength { get; set; }

        /// <summary>
        /// Gets the character's agility.
        /// </summary>
        [JsonPropertyName("agility")]
        public PrimaryStatistic Agility { get; set; }

        /// <summary>
        /// Gets the character's intellect.
        /// </summary>
        [JsonPropertyName("intellect")]
        public PrimaryStatistic Intellect { get; set; }

        /// <summary>
        /// Gets the character's stamina.
        /// </summary>
        [JsonPropertyName("stamina")]
        public PrimaryStatistic Stamina { get; set; }

        /// <summary>
        /// Gets the character's melee crit.
        /// </summary>
        [JsonPropertyName("melee_crit")]
        public RatingStatistic MeleeCrit { get; set; }

        /// <summary>
        /// Gets the character's melee haste.
        /// </summary>
        [JsonPropertyName("melee_haste")]
        public RatingStatistic MeleeHaste { get; set; }

        /// <summary>
        /// Gets the character's mastery.
        /// </summary>
        [JsonPropertyName("mastery")]
        public RatingStatistic Mastery { get; set; }

        /// <summary>
        /// Gets the character's bonus armor.
        /// </summary>
        [JsonPropertyName("bonus_armor")]
        public int BonusArmor { get; set; }

        /// <summary>
        /// Gets the character's lifesteal.
        /// </summary>
        [JsonPropertyName("lifesteal")]
        public RatingStatistic Lifesteal { get; set; }

        /// <summary>
        /// Gets the character's versatility.
        /// </summary>
        [JsonPropertyName("versatility")]
        public int Versatility { get; set; }

        /// <summary>
        /// Gets the character's versatility damage done bonus.
        /// </summary>
        [JsonPropertyName("versatility_damage_done_bonus")]
        public double VersatilityDamageDoneBonus { get; set; }

        /// <summary>
        /// Gets the character's versatility healing done bonus.
        /// </summary>
        [JsonPropertyName("versatility_healing_done_bonus")]
        public double VersatilityHealingDoneBonus { get; set; }

        /// <summary>
        /// Gets the character's versatility damage taken bonus.
        /// </summary>
        [JsonPropertyName("versatility_damage_taken_bonus")]
        public double VersatilityDamageTakenBonus { get; set; }

        /// <summary>
        /// Gets the character's avoidance.
        /// </summary>
        [JsonPropertyName("avoidance")]
        public RatingStatisticWithoutValue Avoidance { get; set; }

        /// <summary>
        /// Gets the character's attack power.
        /// </summary>
        [JsonPropertyName("attack_power")]
        public int AttackPower { get; set; }

        /// <summary>
        /// Gets the character's main hand damage minimum.
        /// </summary>
        [JsonPropertyName("main_hand_damage_min")]
        public double MainHandDamageMin { get; set; }

        /// <summary>
        /// Gets the character's main hand damage maximum.
        /// </summary>
        [JsonPropertyName("main_hand_damage_max")]
        public double MainHandDamageMax { get; set; }

        /// <summary>
        /// Gets the character's main hand speed.
        /// </summary>
        [JsonPropertyName("main_hand_speed")]
        public double MainHandSpeed { get; set; }

        /// <summary>
        /// Gets the character's main hand DPS.
        /// </summary>
        [JsonPropertyName("main_hand_dps")]
        public double MainHandDps { get; set; }

        /// <summary>
        /// Gets the character's off hand damage minimum.
        /// </summary>
        [JsonPropertyName("off_hand_damage_min")]
        public double OffHandDamageMin { get; set; }

        /// <summary>
        /// Gets the character's off hand damage maximum.
        /// </summary>
        [JsonPropertyName("off_hand_damage_max")]
        public double OffHandDamageMax { get; set; }

        /// <summary>
        /// Gets the character's off hand speed.
        /// </summary>
        [JsonPropertyName("off_hand_speed")]
        public double OffHandSpeed { get; set; }

        /// <summary>
        /// Gets the character's off hand DPS.
        /// </summary>
        [JsonPropertyName("off_hand_dps")]
        public double OffHandDps { get; set; }

        /// <summary>
        /// Gets the character's spell power.
        /// </summary>
        [JsonPropertyName("spell_power")]
        public int SpellPower { get; set; }

        /// <summary>
        /// Gets the character's spell penetration.
        /// </summary>
        [JsonPropertyName("spell_penetration")]
        public int SpellPenetration { get; set; }

        /// <summary>
        /// Gets the character's spell crit.
        /// </summary>
        [JsonPropertyName("spell_crit")]
        public RatingStatistic SpellCrit { get; set; }

        /// <summary>
        /// Gets the character's mana regeneration.
        /// </summary>
        [JsonPropertyName("mana_regen")]
        public int ManaRegen { get; set; }

        /// <summary>
        /// Gets the character's mana regeneration in combat.
        /// </summary>
        [JsonPropertyName("mana_regen_combat")]
        public int ManaRegenCombat { get; set; }

        /// <summary>
        /// Gets the character's armor.
        /// </summary>
        [JsonPropertyName("armor")]
        public PrimaryStatistic Armor { get; set; }

        /// <summary>
        /// Gets the character's dodge.
        /// </summary>
        [JsonPropertyName("dodge")]
        public RatingStatistic Dodge { get; set; }

        /// <summary>
        /// Gets the character's parry.
        /// </summary>
        [JsonPropertyName("parry")]
        public RatingStatistic Parry { get; set; }

        /// <summary>
        /// Gets the character's block.
        /// </summary>
        [JsonPropertyName("block")]
        public RatingStatistic Block { get; set; }

        /// <summary>
        /// Gets the character's ranged crit.
        /// </summary>
        [JsonPropertyName("ranged_crit")]
        public RatingStatistic RangedCrit { get; set; }

        /// <summary>
        /// Gets the character's ranged haste.
        /// </summary>
        [JsonPropertyName("ranged_haste")]
        public RatingStatistic RangedHaste { get; set; }

        /// <summary>
        /// Gets the character's spell haste.
        /// </summary>
        [JsonPropertyName("spell_haste")]
        public RatingStatistic SpellHaste { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's corruption.
        /// </summary>
        [JsonPropertyName("corruption")]
        public CorruptionStatistics Corruption { get; set; }
    }
}
