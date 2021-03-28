using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A weapon.
    /// </summary>
    public record Weapon
    {
        /// <summary>
        /// Gets the damage of the weapon.
        /// </summary>
        [JsonPropertyName("damage")]
        public Damage Damage { get; }

        /// <summary>
        /// Gets the attack speed of the weapon.
        /// </summary>
        [JsonPropertyName("attack_speed")]
        public DescribedValue AttackSpeed { get; }

        /// <summary>
        /// Gets the damage per second (DPS) of the weapon.
        /// </summary>
        [JsonPropertyName("dps")]
        public DescribedValue Dps { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weapon"/> class.
        /// </summary>
        /// <param name="damage">The damage of the weapon.</param>
        /// <param name="attackSpeed">The attack speed of the weapon.</param>
        /// <param name="dps">The damage per second (DPS) of the weapon.</param>
        [JsonConstructor]
        public Weapon(Damage damage, DescribedValue attackSpeed, DescribedValue dps)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
            Dps = dps;
        }
    }
}
