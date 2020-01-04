using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// Character stats.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Gets or sets the health.
        /// </summary>
        [JsonProperty("health")]
        public int Health { get; set; }

        /// <summary>
        /// Gets or sets the power type.
        /// </summary>
        [JsonProperty("powerType")]
        public string PowerType { get; set; }

        /// <summary>
        /// Gets or sets the power.
        /// </summary>
        [JsonProperty("power")]
        public int Power { get; set; }

        /// <summary>
        /// Gets or sets the strength.
        /// </summary>
        [JsonProperty("str")]
        public int Strength { get; set; }

        /// <summary>
        /// Gets or sets the agility.
        /// </summary>
        [JsonProperty("agi")]
        public int Agility { get; set; }

        /// <summary>
        /// Gets or sets the intelligence.
        /// </summary>
        [JsonProperty("int")]
        public int Intelligence { get; set; }

        /// <summary>
        /// Gets or sets the stamina.
        /// </summary>
        [JsonProperty("sta")]
        public int Stamina { get; set; }

        /// <summary>
        /// Gets or sets the speed rating.
        /// </summary>
        [JsonProperty("speedRating")]
        public double SpeedRating { get; set; }

        /// <summary>
        /// Gets or sets the speed rating bonus.
        /// </summary>
        [JsonProperty("speedRatingBonus")]
        public double SpeedRatingBonus { get; set; }

        /// <summary>
        /// Gets or sets the crit.
        /// </summary>
        [JsonProperty("crit")]
        public double Crit { get; set; }

        /// <summary>
        /// Gets or sets the crit rating.
        /// </summary>
        [JsonProperty("critRating")]
        public int CritRating { get; set; }

        /// <summary>
        /// Gets or sets the haste.
        /// </summary>
        [JsonProperty("haste")]
        public double Haste { get; set; }

        /// <summary>
        /// Gets or sets the haste rating.
        /// </summary>
        [JsonProperty("hasteRating")]
        public int HasteRating { get; set; }

        /// <summary>
        /// Gets or sets the haste rating percent.
        /// </summary>
        [JsonProperty("hasteRatingPercent")]
        public double HasteRatingPercent { get; set; }

        /// <summary>
        /// Gets or sets the mastery.
        /// </summary>
        [JsonProperty("mastery")]
        public double Mastery { get; set; }

        /// <summary>
        /// Gets or sets the mastery rating.
        /// </summary>
        [JsonProperty("masteryRating")]
        public int MasteryRating { get; set; }

        /// <summary>
        /// Gets or sets the leech.
        /// </summary>
        [JsonProperty("leech")]
        public double Leech { get; set; }

        /// <summary>
        /// Gets or sets the leech rating.
        /// </summary>
        [JsonProperty("leechRating")]
        public double LeechRating { get; set; }

        /// <summary>
        /// Gets or sets the leech rating bonus.
        /// </summary>
        [JsonProperty("leechRatingBonus")]
        public double LeechRatingBonus { get; set; }

        /// <summary>
        /// Gets or sets the versatility.
        /// </summary>
        [JsonProperty("versatility")]
        public int Versatility { get; set; }

        /// <summary>
        /// Gets or sets the versatility damage done bonus.
        /// </summary>
        [JsonProperty("versatilityDamageDoneBonus")]
        public double VersatilityDamageDoneBonus { get; set; }

        /// <summary>
        /// Gets or sets the versatility healing done bonus.
        /// </summary>
        [JsonProperty("versatilityHealingDoneBonus")]
        public double VersatilityHealingDoneBonus { get; set; }

        /// <summary>
        /// Gets or sets the versatility damage taken bonus.
        /// </summary>
        [JsonProperty("versatilityDamageTakenBonus")]
        public double VersatilityDamageTakenBonus { get; set; }

        /// <summary>
        /// Gets or sets the avoidance rating.
        /// </summary>
        [JsonProperty("avoidanceRating")]
        public double AvoidanceRating { get; set; }

        /// <summary>
        /// Gets or sets the avoidance rating bonus.
        /// </summary>
        [JsonProperty("avoidanceRatingBonus")]
        public double AvoidanceRatingBonus { get; set; }

        /// <summary>
        /// Gets or sets the spell penetration.
        /// </summary>
        [JsonProperty("spellPen")]
        public int SpellPenetration { get; set; }

        /// <summary>
        /// Gets or sets the spell crit.
        /// </summary>
        [JsonProperty("spellCrit")]
        public double SpellCrit { get; set; }

        /// <summary>
        /// Gets or sets the spell crit rating.
        /// </summary>
        [JsonProperty("spellCritRating")]
        public int SpellCritRating { get; set; }

        /// <summary>
        /// Gets or sets the mana 5.
        /// </summary>
        [JsonProperty("mana5")]
        public double Mana5 { get; set; }

        /// <summary>
        /// Gets or sets the mana 5 combat.
        /// </summary>
        [JsonProperty("mana5Combat")]
        public double Mana5Combat { get; set; }

        /// <summary>
        /// Gets or sets the armor.
        /// </summary>
        [JsonProperty("armor")]
        public int Armor { get; set; }

        /// <summary>
        /// Gets or sets the dodge.
        /// </summary>
        [JsonProperty("dodge")]
        public double Dodge { get; set; }

        /// <summary>
        /// Gets or sets the dodge rating.
        /// </summary>
        [JsonProperty("dodgeRating")]
        public int DodgeRating { get; set; }

        /// <summary>
        /// Gets or sets the parry.
        /// </summary>
        [JsonProperty("parry")]
        public double Parry { get; set; }

        /// <summary>
        /// Gets or sets the parry rating.
        /// </summary>
        [JsonProperty("parryRating")]
        public int ParryRating { get; set; }

        /// <summary>
        /// Gets or sets the block.
        /// </summary>
        [JsonProperty("block")]
        public double Block { get; set; }

        /// <summary>
        /// Gets or sets the block rating.
        /// </summary>
        [JsonProperty("blockRating")]
        public int BlockRating { get; set; }

        /// <summary>
        /// Gets or sets the main hand damage minimum.
        /// </summary>
        [JsonProperty("mainHandDmgMin")]
        public double MainHandDamageMin { get; set; }

        /// <summary>
        /// Gets or sets the main hand damage maximum.
        /// </summary>
        [JsonProperty("mainHandDmgMax")]
        public double MainHandDamageMax { get; set; }

        /// <summary>
        /// Gets or sets the main hand speed.
        /// </summary>
        [JsonProperty("mainHandSpeed")]
        public double MainHandSpeed { get; set; }

        /// <summary>
        /// Gets or sets the main hand DPS.
        /// </summary>
        [JsonProperty("mainHandDps")]
        public double MainHandDps { get; set; }

        /// <summary>
        /// Gets or sets the off hand damage minimum.
        /// </summary>
        [JsonProperty("offHandDmgMin")]
        public double OffHandDamageMin { get; set; }

        /// <summary>
        /// Gets or sets the off hand damage maximum.
        /// </summary>
        [JsonProperty("offHandDmgMax")]
        public double OffHandDamageMax { get; set; }

        /// <summary>
        /// Gets or sets the off hand speed.
        /// </summary>
        [JsonProperty("offHandSpeed")]
        public double OffHandSpeed { get; set; }

        /// <summary>
        /// Gets or sets the off hand DPS.
        /// </summary>
        [JsonProperty("offHandDps")]
        public double OffHandDps { get; set; }

        /// <summary>
        /// Gets or sets the ranged damage minimum.
        /// </summary>
        [JsonProperty("rangedDmgMin")]
        public double RangedDamageMin { get; set; }

        /// <summary>
        /// Gets or sets the ranged damage maximum.
        /// </summary>
        [JsonProperty("rangedDmgMax")]
        public double RangedDamageMax { get; set; }

        /// <summary>
        /// Gets or sets the ranged speed.
        /// </summary>
        [JsonProperty("rangedSpeed")]
        public double RangedSpeed { get; set; }

        /// <summary>
        /// Gets or sets the ranged DPS.
        /// </summary>
        [JsonProperty("rangedDps")]
        public double RangedDps { get; set; }
    }
}
