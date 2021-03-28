using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A party member for a Mythic Keystone dungeon.
    /// </summary>
    public record MythicKeystonePartyMember
    {
        /// <summary>
        /// Gets details about the character.
        /// </summary>
        [JsonPropertyName("character")]
        public MemberCharacter Character { get; }

        /// <summary>
        /// Gets a reference to the specialization of the character.
        /// </summary>
        [JsonPropertyName("specialization")]
        public PlayableSpecializationReference Specialization { get; }

        /// <summary>
        /// Gets a reference to the race of the character.
        /// </summary>
        [JsonPropertyName("race")]
        public PlayableRaceReference Race { get; }

        /// <summary>
        /// Gets the equipped item level of the character.
        /// </summary>
        [JsonPropertyName("equipped_item_level")]
        public int EquippedItemLevel { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystonePartyMember"/> class.
        /// </summary>
        /// <param name="character">Details about the character.</param>
        /// <param name="specialization">A reference to the specialization of the character.</param>
        /// <param name="race">A reference to the race of the character.</param>
        /// <param name="equippedItemLevel">The equipped item level of the character.</param>
        [JsonConstructor]
        public MythicKeystonePartyMember(MemberCharacter character, PlayableSpecializationReference specialization, PlayableRaceReference race, int equippedItemLevel)
        {
            Character = character;
            Specialization = specialization;
            Race = race;
            EquippedItemLevel = equippedItemLevel;
        }
    }
}
