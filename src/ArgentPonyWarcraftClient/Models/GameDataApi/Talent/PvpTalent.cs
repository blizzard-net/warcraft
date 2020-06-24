using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the PvP talent.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the spell associated with this talent.
        /// </summary>
        [JsonProperty("spell")]
        public SpellReference Spell { get; set; }

        /// <summary>
        /// Gets a reference to the playable specialization associated with this talent.
        /// </summary>
        [JsonProperty("playable_specialization")]
        public PlayableSpecializationReference PlayableSpecialization { get; set; }

        /// <summary>
        /// Gets a reference to the spell that this talent overrides.
        /// </summary>
        [JsonProperty("overrides_spell")]
        public SpellReference OverridesSpell { get; set; }

        /// <summary>
        /// Gets the description of the PvP talent.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the levle at which the player unlocks this PvP talent.
        /// </summary>
        [JsonProperty("unlock_player_level")]
        public long UnlockPlayerLevel { get; set; }

        /// <summary>
        /// Gets the compatible slots for this talent.
        /// </summary>
        [JsonProperty("compatible_slots")]
        public long[] CompatibleSlots { get; set; }
    }
}
