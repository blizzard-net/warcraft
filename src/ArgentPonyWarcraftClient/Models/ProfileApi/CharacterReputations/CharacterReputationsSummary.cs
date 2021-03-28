using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of a character's reputations.
    /// </summary>
    public record CharacterReputationsSummary
    {
        /// <summary>
        /// Gets links for the summary of the character's reputations.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets 
        /// </summary>
        [JsonPropertyName("reputations")]
        public Reputation[] Reputations { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReputationsSummary"/> class.
        /// </summary>
        /// <param name="links">Links for the summary of the character's reputations.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="reputations"></param>
        [JsonConstructor]
        public CharacterReputationsSummary(Links links, CharacterReference character, Reputation[] reputations)
        {
            Links = links;
            Character = character;
            Reputations = reputations;
        }
    }
}
