using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP talent.
    /// </summary>
    public record PvpTalent
    {
        /// <summary>
        /// Gets links for the PvP talent.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the PvP talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the spell associated with this talent.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; }

        /// <summary>
        /// Gets a reference to the playable specialization associated with this talent.
        /// </summary>
        [JsonPropertyName("playable_specialization")]
        public PlayableSpecializationReference PlayableSpecialization { get; }

        /// <summary>
        /// Gets a reference to the spell that this talent overrides.
        /// </summary>
        [JsonPropertyName("overrides_spell")]
        public SpellReference OverridesSpell { get; }

        /// <summary>
        /// Gets the description of the PvP talent.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the levle at which the player unlocks this PvP talent.
        /// </summary>
        [JsonPropertyName("unlock_player_level")]
        public int UnlockPlayerLevel { get; }

        /// <summary>
        /// Gets the compatible slots for this talent.
        /// </summary>
        [JsonPropertyName("compatible_slots")]
        public int[] CompatibleSlots { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpTalent"/> class.
        /// </summary>
        /// <param name="links">Links for the PvP talent.</param>
        /// <param name="id">The ID of the PvP talent.</param>
        /// <param name="spell">A reference to the spell associated with this talent.</param>
        /// <param name="playableSpecialization">A reference to the playable specialization associated with this talent.</param>
        /// <param name="overridesSpell">A reference to the spell that this talent overrides.</param>
        /// <param name="description">The description of the PvP talent.</param>
        /// <param name="unlockPlayerLevel">The levle at which the player unlocks this PvP talent.</param>
        /// <param name="compatibleSlots">The compatible slots for this talent.</param>
        [JsonConstructor]
        public PvpTalent(Links links, int id, SpellReference spell, PlayableSpecializationReference playableSpecialization, SpellReference overridesSpell, string description, int unlockPlayerLevel, int[] compatibleSlots)
        {
            Links = links;
            Id = id;
            Spell = spell;
            PlayableSpecialization = playableSpecialization;
            OverridesSpell = overridesSpell;
            Description = description;
            UnlockPlayerLevel = unlockPlayerLevel;
            CompatibleSlots = compatibleSlots;
        }
    }
}
