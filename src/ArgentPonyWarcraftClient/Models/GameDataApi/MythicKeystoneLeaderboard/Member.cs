using System.Text.Json.Serialization;

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
        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }

        /// <summary>
        /// Gets the character's faction (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumTypeWithoutName Faction { get; set; }

        /// <summary>
        /// Gets the character's specialization.
        /// </summary>
        [JsonPropertyName("specialization")]
        public PlayableSpecializationReferenceWithoutName Specialization { get; set; }
    }
}
