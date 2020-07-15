using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the character's health.
        /// </summary>
        [JsonProperty("health")]
        public long Health { get; set; }

        /// <summary>
        /// Gets the character's power.
        /// </summary>
        [JsonProperty("power")]
        public long Power { get; set; }

        /// <summary>
        /// Gets a reference to the character's power type.
        /// </summary>
        [JsonProperty("power_type")]
        public PowerTypeReference PowerType { get; set; }

        /// <summary>
        /// Gets the character's speed.
        /// </summary>
        [JsonProperty("speed")]
        public RatingStatisticWithoutValue Speed { get; set; }

        /// <summary>
        /// Gets the character's strength.
        /// </summary>
        [JsonProperty("strength")]
        public PrimaryStatistic Strength { get; set; }

        /// <summary>
        /// Gets the character's agility.
        /// </summary>
        [JsonProperty("agility")]
        public PrimaryStatistic Agility { get; set; }

        /// <summary>
        /// Gets the character's intellect.
        /// </summary>
        [JsonProperty("intellect")]
        public PrimaryStatistic Intellect { get; set; }

        /// <summary>
        /// Gets the character's stamina.
        /// </summary>
        [JsonProperty("stamina")]
        public PrimaryStatistic Stamina { get; set; }

        /// <summary>
        /// Gets the character's melee crit.
        /// </summary>
        [JsonProperty("melee_crit")]
        public RatingStatistic MeleeCrit { get; set; }

        /// <summary>
        /// Gets the character's melee haste.
        /// </summary>
        [JsonProperty("melee_haste")]
        public RatingStatistic MeleeHaste { get; set; }

        /// <summary>
        /// Gets the character's mastery.
        /// </summary>
        [JsonProperty("mastery")]
        public RatingStatistic Mastery { get; set; }

        /// <summary>
        /// Gets the character's bonus armor.
        /// </summary>
        [JsonProperty("bonus_armor")]
        public long BonusArmor { get; set; }

        /// <summary>
        /// Gets the character's lifesteal.
        /// </summary>
        [JsonProperty("lifesteal")]
        public RatingStatistic Lifesteal { get; set; }

        /// <summary>
        /// Gets the character's versatility.
        /// </summary>
        [JsonProperty("versatility")]
        public long Versatility { get; set; }

        /// <summary>
        /// Gets the character's versatility damage done bonus.
        /// </summary>
        [JsonProperty("versatility_damage_done_bonus")]
        public double VersatilityDamageDoneBonus { get; set; }

        /// <summary>
        /// Gets the character's versatility healing done bonus.
        /// </summary>
        [JsonProperty("versatility_healing_done_bonus")]
        public double VersatilityHealingDoneBonus { get; set; }

        /// <summary>
        /// Gets the character's versatility damage taken bonus.
        /// </summary>
        [JsonProperty("versatility_damage_taken_bonus")]
        public double VersatilityDamageTakenBonus { get; set; }

        /// <summary>
        /// Gets the character's avoidance.
        /// </summary>
        [JsonProperty("avoidance")]
        public RatingStatisticWithoutValue Avoidance { get; set; }

        /// <summary>
        /// Gets the character's attack power.
        /// </summary>
        [JsonProperty("attack_power")]
        public long AttackPower { get; set; }

        /// <summary>
        /// Gets the character's main hand damage minimum.
        /// </summary>
        [JsonProperty("main_hand_damage_min")]
        public double MainHandDamageMin { get; set; }

        /// <summary>
        /// Gets the character's main hand damage maximum.
        /// </summary>
        [JsonProperty("main_hand_damage_max")]
        public double MainHandDamageMax { get; set; }

        /// <summary>
        /// Gets the character's main hand speed.
        /// </summary>
        [JsonProperty("main_hand_speed")]
        public double MainHandSpeed { get; set; }

        /// <summary>
        /// Gets the character's main hand DPS.
        /// </summary>
        [JsonProperty("main_hand_dps")]
        public double MainHandDps { get; set; }

        /// <summary>
        /// Gets the character's off hand damage minimum.
        /// </summary>
        [JsonProperty("off_hand_damage_min")]
        public double OffHandDamageMin { get; set; }

        /// <summary>
        /// Gets the character's off hand damage maximum.
        /// </summary>
        [JsonProperty("off_hand_damage_max")]
        public double OffHandDamageMax { get; set; }

        /// <summary>
        /// Gets the character's off hand speed.
        /// </summary>
        [JsonProperty("off_hand_speed")]
        public double OffHandSpeed { get; set; }

        /// <summary>
        /// Gets the character's off hand DPS.
        /// </summary>
        [JsonProperty("off_hand_dps")]
        public double OffHandDps { get; set; }

        /// <summary>
        /// Gets the character's spell power.
        /// </summary>
        [JsonProperty("spell_power")]
        public long SpellPower { get; set; }

        /// <summary>
        /// Gets the character's spell penetration.
        /// </summary>
        [JsonProperty("spell_penetration")]
        public long SpellPenetration { get; set; }

        /// <summary>
        /// Gets the character's spell crit.
        /// </summary>
        [JsonProperty("spell_crit")]
        public RatingStatistic SpellCrit { get; set; }

        /// <summary>
        /// Gets the character's mana regeneration.
        /// </summary>
        [JsonProperty("mana_regen")]
        public long ManaRegen { get; set; }

        /// <summary>
        /// Gets the character's mana regeneration in combat.
        /// </summary>
        [JsonProperty("mana_regen_combat")]
        public long ManaRegenCombat { get; set; }

        /// <summary>
        /// Gets the character's armor.
        /// </summary>
        [JsonProperty("armor")]
        public PrimaryStatistic Armor { get; set; }

        /// <summary>
        /// Gets the character's dodge.
        /// </summary>
        [JsonProperty("dodge")]
        public RatingStatistic Dodge { get; set; }

        /// <summary>
        /// Gets the character's parry.
        /// </summary>
        [JsonProperty("parry")]
        public RatingStatistic Parry { get; set; }

        /// <summary>
        /// Gets the character's block.
        /// </summary>
        [JsonProperty("block")]
        public RatingStatistic Block { get; set; }

        /// <summary>
        /// Gets the character's ranged crit.
        /// </summary>
        [JsonProperty("ranged_crit")]
        public RatingStatistic RangedCrit { get; set; }

        /// <summary>
        /// Gets the character's ranged haste.
        /// </summary>
        [JsonProperty("ranged_haste")]
        public RatingStatistic RangedHaste { get; set; }

        /// <summary>
        /// Gets the character's spell haste.
        /// </summary>
        [JsonProperty("spell_haste")]
        public RatingStatistic SpellHaste { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonProperty("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets the character's corruption.
        /// </summary>
        [JsonProperty("corruption")]
        public CorruptionStatistics Corruption { get; set; }
    }
}
