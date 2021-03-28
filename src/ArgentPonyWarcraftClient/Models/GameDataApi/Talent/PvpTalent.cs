using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent.
    /// </summary>
    public class PvpTalent
    {
        /// <summary>
        /// Gets links for the PvP talent.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the PvP talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets a reference to the spell associated with this talent.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; set; }

        /// <summary>
        /// Gets a reference to the playable specialization associated with this talent.
        /// </summary>
        [JsonPropertyName("playable_specialization")]
        public PlayableSpecializationReference PlayableSpecialization { get; set; }

        /// <summary>
        /// Gets a reference to the spell that this talent overrides.
        /// </summary>
        [JsonPropertyName("overrides_spell")]
        public SpellReference OverridesSpell { get; set; }

        /// <summary>
        /// Gets the description of the PvP talent.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the levle at which the player unlocks this PvP talent.
        /// </summary>
        [JsonPropertyName("unlock_player_level")]
        public int UnlockPlayerLevel { get; set; }

        /// <summary>
        /// Gets the compatible slots for this talent.
        /// </summary>
        [JsonPropertyName("compatible_slots")]
        public int[] CompatibleSlots { get; set; }
    }
}
