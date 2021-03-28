using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A statistics summary for a character.
    /// </summary>
    public record CharacterStatisticsSummary
    {
        /// <summary>
        /// Gets links for the statistics summary for the character.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the character's health.
        /// </summary>
        [JsonPropertyName("health")]
        public int Health { get; }

        /// <summary>
        /// Gets the character's power.
        /// </summary>
        [JsonPropertyName("power")]
        public int Power { get; }

        /// <summary>
        /// Gets a reference to the character's power type.
        /// </summary>
        [JsonPropertyName("power_type")]
        public PowerTypeReference PowerType { get; }

        /// <summary>
        /// Gets the character's speed.
        /// </summary>
        [JsonPropertyName("speed")]
        public RatingStatisticWithoutValue Speed { get; }

        /// <summary>
        /// Gets the character's strength.
        /// </summary>
        [JsonPropertyName("strength")]
        public PrimaryStatistic Strength { get; }

        /// <summary>
        /// Gets the character's agility.
        /// </summary>
        [JsonPropertyName("agility")]
        public PrimaryStatistic Agility { get; }

        /// <summary>
        /// Gets the character's intellect.
        /// </summary>
        [JsonPropertyName("intellect")]
        public PrimaryStatistic Intellect { get; }

        /// <summary>
        /// Gets the character's stamina.
        /// </summary>
        [JsonPropertyName("stamina")]
        public PrimaryStatistic Stamina { get; }

        /// <summary>
        /// Gets the character's melee crit.
        /// </summary>
        [JsonPropertyName("melee_crit")]
        public RatingStatistic MeleeCrit { get; }

        /// <summary>
        /// Gets the character's melee haste.
        /// </summary>
        [JsonPropertyName("melee_haste")]
        public RatingStatistic MeleeHaste { get; }

        /// <summary>
        /// Gets the character's mastery.
        /// </summary>
        [JsonPropertyName("mastery")]
        public RatingStatistic Mastery { get; }

        /// <summary>
        /// Gets the character's bonus armor.
        /// </summary>
        [JsonPropertyName("bonus_armor")]
        public int BonusArmor { get; }

        /// <summary>
        /// Gets the character's lifesteal.
        /// </summary>
        [JsonPropertyName("lifesteal")]
        public RatingStatistic Lifesteal { get; }

        /// <summary>
        /// Gets the character's versatility.
        /// </summary>
        [JsonPropertyName("versatility")]
        public float Versatility { get; }

        /// <summary>
        /// Gets the character's versatility damage done bonus.
        /// </summary>
        [JsonPropertyName("versatility_damage_done_bonus")]
        public float VersatilityDamageDoneBonus { get; }

        /// <summary>
        /// Gets the character's versatility healing done bonus.
        /// </summary>
        [JsonPropertyName("versatility_healing_done_bonus")]
        public float VersatilityHealingDoneBonus { get; }

        /// <summary>
        /// Gets the character's versatility damage taken bonus.
        /// </summary>
        [JsonPropertyName("versatility_damage_taken_bonus")]
        public float VersatilityDamageTakenBonus { get; }

        /// <summary>
        /// Gets the character's avoidance.
        /// </summary>
        [JsonPropertyName("avoidance")]
        public RatingStatisticWithoutValue Avoidance { get; }

        /// <summary>
        /// Gets the character's attack power.
        /// </summary>
        [JsonPropertyName("attack_power")]
        public int AttackPower { get; }

        /// <summary>
        /// Gets the character's main hand damage minimum.
        /// </summary>
        [JsonPropertyName("main_hand_damage_min")]
        public float MainHandDamageMin { get; }

        /// <summary>
        /// Gets the character's main hand damage maximum.
        /// </summary>
        [JsonPropertyName("main_hand_damage_max")]
        public float MainHandDamageMax { get; }

        /// <summary>
        /// Gets the character's main hand speed.
        /// </summary>
        [JsonPropertyName("main_hand_speed")]
        public float MainHandSpeed { get; }

        /// <summary>
        /// Gets the character's main hand DPS.
        /// </summary>
        [JsonPropertyName("main_hand_dps")]
        public float MainHandDps { get; }

        /// <summary>
        /// Gets the character's off hand damage minimum.
        /// </summary>
        [JsonPropertyName("off_hand_damage_min")]
        public float OffHandDamageMin { get; }

        /// <summary>
        /// Gets the character's off hand damage maximum.
        /// </summary>
        [JsonPropertyName("off_hand_damage_max")]
        public float OffHandDamageMax { get; }

        /// <summary>
        /// Gets the character's off hand speed.
        /// </summary>
        [JsonPropertyName("off_hand_speed")]
        public float OffHandSpeed { get; }

        /// <summary>
        /// Gets the character's off hand DPS.
        /// </summary>
        [JsonPropertyName("off_hand_dps")]
        public float OffHandDps { get; }

        /// <summary>
        /// Gets the character's spell power.
        /// </summary>
        [JsonPropertyName("spell_power")]
        public int SpellPower { get; }

        /// <summary>
        /// Gets the character's spell penetration.
        /// </summary>
        [JsonPropertyName("spell_penetration")]
        public int SpellPenetration { get; }

        /// <summary>
        /// Gets the character's spell crit.
        /// </summary>
        [JsonPropertyName("spell_crit")]
        public RatingStatistic SpellCrit { get; }

        /// <summary>
        /// Gets the character's mana regeneration.
        /// </summary>
        [JsonPropertyName("mana_regen")]
        public float ManaRegen { get; }

        /// <summary>
        /// Gets the character's mana regeneration in combat.
        /// </summary>
        [JsonPropertyName("mana_regen_combat")]
        public float ManaRegenCombat { get; }

        /// <summary>
        /// Gets the character's armor.
        /// </summary>
        [JsonPropertyName("armor")]
        public PrimaryStatistic Armor { get; }

        /// <summary>
        /// Gets the character's dodge.
        /// </summary>
        [JsonPropertyName("dodge")]
        public RatingStatistic Dodge { get; }

        /// <summary>
        /// Gets the character's parry.
        /// </summary>
        [JsonPropertyName("parry")]
        public RatingStatistic Parry { get; }

        /// <summary>
        /// Gets the character's block.
        /// </summary>
        [JsonPropertyName("block")]
        public RatingStatistic Block { get; }

        /// <summary>
        /// Gets the character's ranged crit.
        /// </summary>
        [JsonPropertyName("ranged_crit")]
        public RatingStatistic RangedCrit { get; }

        /// <summary>
        /// Gets the character's ranged haste.
        /// </summary>
        [JsonPropertyName("ranged_haste")]
        public RatingStatistic RangedHaste { get; }

        /// <summary>
        /// Gets the character's spell haste.
        /// </summary>
        [JsonPropertyName("spell_haste")]
        public RatingStatistic SpellHaste { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets the character's corruption.
        /// </summary>
        [JsonPropertyName("corruption")]
        public CorruptionStatistics Corruption { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterStatisticsSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the statistics summary for the character.</param>
        /// <param name="health">The character's health.</param>
        /// <param name="power">The character's power.</param>
        /// <param name="powerType">A reference to the character's power type.</param>
        /// <param name="speed">The character's speed.</param>
        /// <param name="strength">The character's strength.</param>
        /// <param name="agility">The character's agility.</param>
        /// <param name="intellect">The character's intellect.</param>
        /// <param name="stamina">The character's stamina.</param>
        /// <param name="meleeCrit">The character's melee crit.</param>
        /// <param name="meleeHaste">The character's melee haste.</param>
        /// <param name="mastery">The character's mastery.</param>
        /// <param name="bonusArmor">The character's bonus armor.</param>
        /// <param name="lifesteal">The character's lifesteal.</param>
        /// <param name="versatility">The character's versatility.</param>
        /// <param name="versatilityDamageDoneBonus">The character's versatility damage done bonus.</param>
        /// <param name="versatilityHealingDoneBonus">The character's versatility healing done bonus.</param>
        /// <param name="versatilityDamageTakenBonus">The character's versatility damage taken bonus.</param>
        /// <param name="avoidance">The character's avoidance.</param>
        /// <param name="attackPower">The character's attack power.</param>
        /// <param name="mainHandDamageMin">The character's main hand damage minimum.</param>
        /// <param name="mainHandDamageMax">The character's main hand damage maximum.</param>
        /// <param name="mainHandSpeed">The character's main hand speed.</param>
        /// <param name="mainHandDps">The character's main hand DPS.</param>
        /// <param name="offHandDamageMin">The character's off hand damage minimum.</param>
        /// <param name="offHandDamageMax">The character's off hand damage maximum.</param>
        /// <param name="offHandSpeed">The character's off hand speed.</param>
        /// <param name="offHandDps">The character's off hand DPS.</param>
        /// <param name="spellPower">The character's spell power.</param>
        /// <param name="spellPenetration">The character's spell penetration.</param>
        /// <param name="spellCrit">The character's spell crit.</param>
        /// <param name="manaRegen">The character's mana regeneration.</param>
        /// <param name="manaRegenCombat">The character's mana regeneration in combat.</param>
        /// <param name="armor">The character's armor.</param>
        /// <param name="dodge">The character's dodge.</param>
        /// <param name="parry">The character's parry.</param>
        /// <param name="block">The character's block.</param>
        /// <param name="rangedCrit">The character's ranged crit.</param>
        /// <param name="rangedHaste">The character's ranged haste.</param>
        /// <param name="spellHaste">The character's spell haste.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="corruption">The character's corruption.</param>
        [JsonConstructor]
        public CharacterStatisticsSummary(Links links, int health, int power, PowerTypeReference powerType, RatingStatisticWithoutValue speed, PrimaryStatistic strength, PrimaryStatistic agility, PrimaryStatistic intellect, PrimaryStatistic stamina, RatingStatistic meleeCrit, RatingStatistic meleeHaste, RatingStatistic mastery, int bonusArmor, RatingStatistic lifesteal, float versatility, float versatilityDamageDoneBonus, float versatilityHealingDoneBonus, float versatilityDamageTakenBonus, RatingStatisticWithoutValue avoidance, int attackPower, float mainHandDamageMin, float mainHandDamageMax, float mainHandSpeed, float mainHandDps, float offHandDamageMin, float offHandDamageMax, float offHandSpeed, float offHandDps, int spellPower, int spellPenetration, RatingStatistic spellCrit, float manaRegen, float manaRegenCombat, PrimaryStatistic armor, RatingStatistic dodge, RatingStatistic parry, RatingStatistic block, RatingStatistic rangedCrit, RatingStatistic rangedHaste, RatingStatistic spellHaste, CharacterReference character, CorruptionStatistics corruption)
        {
            Links = links;
            Health = health;
            Power = power;
            PowerType = powerType;
            Speed = speed;
            Strength = strength;
            Agility = agility;
            Intellect = intellect;
            Stamina = stamina;
            MeleeCrit = meleeCrit;
            MeleeHaste = meleeHaste;
            Mastery = mastery;
            BonusArmor = bonusArmor;
            Lifesteal = lifesteal;
            Versatility = versatility;
            VersatilityDamageDoneBonus = versatilityDamageDoneBonus;
            VersatilityHealingDoneBonus = versatilityHealingDoneBonus;
            VersatilityDamageTakenBonus = versatilityDamageTakenBonus;
            Avoidance = avoidance;
            AttackPower = attackPower;
            MainHandDamageMin = mainHandDamageMin;
            MainHandDamageMax = mainHandDamageMax;
            MainHandSpeed = mainHandSpeed;
            MainHandDps = mainHandDps;
            OffHandDamageMin = offHandDamageMin;
            OffHandDamageMax = offHandDamageMax;
            OffHandSpeed = offHandSpeed;
            OffHandDps = offHandDps;
            SpellPower = spellPower;
            SpellPenetration = spellPenetration;
            SpellCrit = spellCrit;
            ManaRegen = manaRegen;
            ManaRegenCombat = manaRegenCombat;
            Armor = armor;
            Dodge = dodge;
            Parry = parry;
            Block = block;
            RangedCrit = rangedCrit;
            RangedHaste = rangedHaste;
            SpellHaste = spellHaste;
            Character = character;
            Corruption = corruption;
        }
    }
}
