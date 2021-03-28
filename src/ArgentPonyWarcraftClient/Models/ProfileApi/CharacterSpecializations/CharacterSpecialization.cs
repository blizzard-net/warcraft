using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A specialization for a character.
    /// </summary>
    public record CharacterSpecialization
    {
        /// <summary>
        /// Gets a reference to the playable specialization.
        /// </summary>
        [JsonPropertyName("specialization")]
        public PlayableSpecializationReference Specialization { get; }

        /// <summary>
        /// Gets the character's selected talents.
        /// </summary>
        [JsonPropertyName("talents")]
        public TalentSelection[] Talents { get; }

        /// <summary>
        /// Gets the PvP talent slots for the specialization.
        /// </summary>
        [JsonPropertyName("pvp_talent_slots")]
        public PvpTalentSlot[] PvpTalentSlots { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterSpecialization"/> class.
        /// </summary>
        /// <param name="specialization">A reference to the playable specialization.</param>
        /// <param name="talents">The character's selected talents.</param>
        /// <param name="pvpTalentSlots">The PvP talent slots for the specialization.</param>
        [JsonConstructor]
        public CharacterSpecialization(PlayableSpecializationReference specialization, TalentSelection[] talents, PvpTalentSlot[] pvpTalentSlots)
        {
            Specialization = specialization;
            Talents = talents;
            PvpTalentSlots = pvpTalentSlots;
        }
    }
}
