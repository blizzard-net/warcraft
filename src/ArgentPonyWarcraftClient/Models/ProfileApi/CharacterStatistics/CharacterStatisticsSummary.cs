namespace ArgentPonyWarcraftClient;

/// <summary>
/// A statistics summary for a character.
/// </summary>
public record CharacterStatisticsSummary
{
    /// <summary>
    /// Gets links for the statistics summary for the character.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the character's health.
    /// </summary>
    [JsonPropertyName("health")]
    public int Health { get; init; }

    /// <summary>
    /// Gets the character's power.
    /// </summary>
    [JsonPropertyName("power")]
    public int Power { get; init; }

    /// <summary>
    /// Gets a reference to the character's power type.
    /// </summary>
    [JsonPropertyName("power_type")]
    public PowerTypeReference PowerType { get; init; }

    /// <summary>
    /// Gets the character's speed.
    /// </summary>
    [JsonPropertyName("speed")]
    public RatingStatisticWithoutValue Speed { get; init; }

    /// <summary>
    /// Gets the character's strength.
    /// </summary>
    [JsonPropertyName("strength")]
    public PrimaryStatistic Strength { get; init; }

    /// <summary>
    /// Gets the character's agility.
    /// </summary>
    [JsonPropertyName("agility")]
    public PrimaryStatistic Agility { get; init; }

    /// <summary>
    /// Gets the character's intellect.
    /// </summary>
    [JsonPropertyName("intellect")]
    public PrimaryStatistic Intellect { get; init; }

    /// <summary>
    /// Gets the character's stamina.
    /// </summary>
    [JsonPropertyName("stamina")]
    public PrimaryStatistic Stamina { get; init; }

    /// <summary>
    /// Gets the character's melee crit.
    /// </summary>
    [JsonPropertyName("melee_crit")]
    public RatingStatistic MeleeCrit { get; init; }

    /// <summary>
    /// Gets the character's melee haste.
    /// </summary>
    [JsonPropertyName("melee_haste")]
    public RatingStatistic MeleeHaste { get; init; }

    /// <summary>
    /// Gets the character's mastery.
    /// </summary>
    [JsonPropertyName("mastery")]
    public RatingStatistic Mastery { get; init; }

    /// <summary>
    /// Gets the character's bonus armor.
    /// </summary>
    [JsonPropertyName("bonus_armor")]
    public int BonusArmor { get; init; }

    /// <summary>
    /// Gets the character's lifesteal.
    /// </summary>
    [JsonPropertyName("lifesteal")]
    public RatingStatistic Lifesteal { get; init; }

    /// <summary>
    /// Gets the character's versatility.
    /// </summary>
    [JsonPropertyName("versatility")]
    public float Versatility { get; init; }

    /// <summary>
    /// Gets the character's versatility damage done bonus.
    /// </summary>
    [JsonPropertyName("versatility_damage_done_bonus")]
    public float VersatilityDamageDoneBonus { get; init; }

    /// <summary>
    /// Gets the character's versatility healing done bonus.
    /// </summary>
    [JsonPropertyName("versatility_healing_done_bonus")]
    public float VersatilityHealingDoneBonus { get; init; }

    /// <summary>
    /// Gets the character's versatility damage taken bonus.
    /// </summary>
    [JsonPropertyName("versatility_damage_taken_bonus")]
    public float VersatilityDamageTakenBonus { get; init; }

    /// <summary>
    /// Gets the character's avoidance.
    /// </summary>
    [JsonPropertyName("avoidance")]
    public RatingStatisticWithoutValue Avoidance { get; init; }

    /// <summary>
    /// Gets the character's attack power.
    /// </summary>
    [JsonPropertyName("attack_power")]
    public int AttackPower { get; init; }

    /// <summary>
    /// Gets the character's main hand damage minimum.
    /// </summary>
    [JsonPropertyName("main_hand_damage_min")]
    public float MainHandDamageMin { get; init; }

    /// <summary>
    /// Gets the character's main hand damage maximum.
    /// </summary>
    [JsonPropertyName("main_hand_damage_max")]
    public float MainHandDamageMax { get; init; }

    /// <summary>
    /// Gets the character's main hand speed.
    /// </summary>
    [JsonPropertyName("main_hand_speed")]
    public float MainHandSpeed { get; init; }

    /// <summary>
    /// Gets the character's main hand DPS.
    /// </summary>
    [JsonPropertyName("main_hand_dps")]
    public float MainHandDps { get; init; }

    /// <summary>
    /// Gets the character's off hand damage minimum.
    /// </summary>
    [JsonPropertyName("off_hand_damage_min")]
    public float OffHandDamageMin { get; init; }

    /// <summary>
    /// Gets the character's off hand damage maximum.
    /// </summary>
    [JsonPropertyName("off_hand_damage_max")]
    public float OffHandDamageMax { get; init; }

    /// <summary>
    /// Gets the character's off hand speed.
    /// </summary>
    [JsonPropertyName("off_hand_speed")]
    public float OffHandSpeed { get; init; }

    /// <summary>
    /// Gets the character's off hand DPS.
    /// </summary>
    [JsonPropertyName("off_hand_dps")]
    public float OffHandDps { get; init; }

    /// <summary>
    /// Gets the character's spell power.
    /// </summary>
    [JsonPropertyName("spell_power")]
    public int SpellPower { get; init; }

    /// <summary>
    /// Gets the character's spell penetration.
    /// </summary>
    [JsonPropertyName("spell_penetration")]
    public int SpellPenetration { get; init; }

    /// <summary>
    /// Gets the character's spell crit.
    /// </summary>
    [JsonPropertyName("spell_crit")]
    public RatingStatistic SpellCrit { get; init; }

    /// <summary>
    /// Gets the character's mana regeneration.
    /// </summary>
    [JsonPropertyName("mana_regen")]
    public float ManaRegen { get; init; }

    /// <summary>
    /// Gets the character's mana regeneration in combat.
    /// </summary>
    [JsonPropertyName("mana_regen_combat")]
    public float ManaRegenCombat { get; init; }

    /// <summary>
    /// Gets the character's armor.
    /// </summary>
    [JsonPropertyName("armor")]
    public PrimaryStatistic Armor { get; init; }

    /// <summary>
    /// Gets the character's dodge.
    /// </summary>
    [JsonPropertyName("dodge")]
    public RatingStatistic Dodge { get; init; }

    /// <summary>
    /// Gets the character's parry.
    /// </summary>
    [JsonPropertyName("parry")]
    public RatingStatistic Parry { get; init; }

    /// <summary>
    /// Gets the character's block.
    /// </summary>
    [JsonPropertyName("block")]
    public RatingStatistic Block { get; init; }

    /// <summary>
    /// Gets the character's ranged crit.
    /// </summary>
    [JsonPropertyName("ranged_crit")]
    public RatingStatistic RangedCrit { get; init; }

    /// <summary>
    /// Gets the character's ranged haste.
    /// </summary>
    [JsonPropertyName("ranged_haste")]
    public RatingStatistic RangedHaste { get; init; }

    /// <summary>
    /// Gets the character's spell haste.
    /// </summary>
    [JsonPropertyName("spell_haste")]
    public RatingStatistic SpellHaste { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets the character's corruption.
    /// </summary>
    [JsonPropertyName("corruption")]
    public CorruptionStatistics Corruption { get; init; }
}
