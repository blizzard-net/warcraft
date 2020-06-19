using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A group member.
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Gets the profile of the character.
        /// </summary>
        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        /// <summary>
        /// Gets the character's faction (Alliance or Horde).
        /// </summary>
        [JsonProperty("faction")]
        public EnumTypeWithoutName Faction { get; set; }

        /// <summary>
        /// Gets the character's specialization.
        /// </summary>
        [JsonProperty("specialization")]
        public PlayableSpecializationReferenceWithoutName Specialization { get; set; }
    }
}
