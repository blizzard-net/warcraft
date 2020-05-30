using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A weapon.
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// Gets the damage of the weapon.
        /// </summary>
        [JsonProperty("damage")]
        public Damage Damage { get; set; }

        /// <summary>
        /// Gets the attack speed of the weapon.
        /// </summary>
        [JsonProperty("attack_speed")]
        public DescribedValue AttackSpeed { get; set; }

        /// <summary>
        /// Gets the damage per second (DPS) of the weapon.
        /// </summary>
        [JsonProperty("dps")]
        public DescribedValue Dps { get; set; }
    }
}
