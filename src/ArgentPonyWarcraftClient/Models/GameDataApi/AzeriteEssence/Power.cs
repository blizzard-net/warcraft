using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A power associated with an azerite essence.
    /// </summary>
    public record Power
    {
        /// <summary>
        /// Gets the ID of the azerite essence power.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the rank of the azerite essence power.
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; }

        /// <summary>
        /// Gets a reference to the spell that is the main power for this azerite essence.
        /// </summary>
        [JsonPropertyName("main_power_spell")]
        public SpellReference MainPowerSpell { get; }

        /// <summary>
        /// Gets a reference to the spell that is the passive power for this azerite essence.
        /// </summary>
        [JsonPropertyName("passive_power_spell")]
        public SpellReference PassivePowerSpell { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Power"/> class.
        /// </summary>
        /// <param name="id">The ID of the azerite essence power.</param>
        /// <param name="rank">The rank of the azerite essence power.</param>
        /// <param name="mainPowerSpell">A reference to the spell that is the main power for this azerite essence.</param>
        /// <param name="passivePowerSpell">A reference to the spell that is the passive power for this azerite essence.</param>
        [JsonConstructor]
        public Power(int id, int rank, SpellReference mainPowerSpell, SpellReference passivePowerSpell)
        {
            Id = id;
            Rank = rank;
            MainPowerSpell = mainPowerSpell;
            PassivePowerSpell = passivePowerSpell;
        }
    }
}
