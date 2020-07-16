using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A specialization for a character.
    /// </summary>
    public class CharacterSpecialization
    {
        /// <summary>
        /// Gets a reference to the playable specialization.
        /// </summary>
        [JsonProperty("specialization")]
        public PlayableSpecializationReference Specialization { get; set; }

        /// <summary>
        /// Gets the character's selected talents.
        /// </summary>
        [JsonProperty("talents")]
        public TalentSelection[] Talents { get; set; }

        /// <summary>
        /// Gets the PvP talent slots for the specialization.
        /// </summary>
        [JsonProperty("pvp_talent_slots")]
        public PvpTalentSlot[] PvpTalentSlots { get; set; }
    }
}
