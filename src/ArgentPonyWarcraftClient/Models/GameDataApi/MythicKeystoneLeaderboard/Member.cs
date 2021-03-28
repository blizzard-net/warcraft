using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A group member.
    /// </summary>
    public record Member
    {
        /// <summary>
        /// Gets the profile of the character.
        /// </summary>
        [JsonPropertyName("profile")]
        public Profile Profile { get; }

        /// <summary>
        /// Gets the character's faction (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumTypeWithoutName Faction { get; }

        /// <summary>
        /// Gets the character's specialization.
        /// </summary>
        [JsonPropertyName("specialization")]
        public PlayableSpecializationReferenceWithoutName Specialization { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="profile">The profile of the character.</param>
        /// <param name="faction">The character's faction (Alliance or Horde).</param>
        /// <param name="specialization">The character's specialization.</param>
        [JsonConstructor]
        public Member(Profile profile, EnumTypeWithoutName faction, PlayableSpecializationReferenceWithoutName specialization)
        {
            Profile = profile;
            Faction = faction;
            Specialization = specialization;
        }
    }
}
