using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's soulbinds.
    /// </summary>
    public record CharacterSoulbinds
    {
        /// <summary>
        /// Gets links for the character's soulbinds.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets a reference to the character's chosen covenant.
        /// </summary>
        [JsonPropertyName("chosen_covenant")]
        public CovenantReference ChosenCovenant { get; }

        /// <summary>
        /// Gets the renown level for the character with the chosen covenant.
        /// </summary>
        [JsonPropertyName("renown_level")]
        public long RenownLevel { get; }

        /// <summary>
        /// Gets the soulbinds for the character.
        /// </summary>
        [JsonPropertyName("soulbinds")]
        public SoulbindSelection[] Soulbinds { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterSoulbinds"/> class.
        /// </summary>
        /// <param name="links">Links for the character's soulbinds.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="chosenCovenant">A reference to the character's chosen covenant.</param>
        /// <param name="renownLevel">The renown level for the character with the chosen covenant.</param>
        /// <param name="soulbinds">The soulbinds for the character.</param>
        [JsonConstructor]
        public CharacterSoulbinds(Links links, CharacterReference character, CovenantReference chosenCovenant, long renownLevel, SoulbindSelection[] soulbinds)
        {
            Links = links;
            Character = character;
            ChosenCovenant = chosenCovenant;
            RenownLevel = renownLevel;
            Soulbinds = soulbinds;
        }
    }
}
