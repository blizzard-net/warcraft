using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A weapon.
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// Gets the damage of the weapon.
        /// </summary>
        [JsonPropertyName("damage")]
        public Damage Damage { get; set; }

        /// <summary>
        /// Gets the attack speed of the weapon.
        /// </summary>
        [JsonPropertyName("attack_speed")]
        public DescribedValue AttackSpeed { get; set; }

        /// <summary>
        /// Gets the damage per second (DPS) of the weapon.
        /// </summary>
        [JsonPropertyName("dps")]
        public DescribedValue Dps { get; set; }
    }
}
