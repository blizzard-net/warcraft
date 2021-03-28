using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character's completed instances for a game expansion.
    /// </summary>
    public record CharacterExpansionInstances
    {
        /// <summary>
        /// Gets a reference to a game expansion.
        /// </summary>
        [JsonPropertyName("expansion")]
        public ExpansionReference Expansion { get; }

        /// <summary>
        /// Gets the character's completed instances for the game expansion.
        /// </summary>
        [JsonPropertyName("instances")]
        public CharacterInstance[] Instances { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterExpansionInstances"/> class.
        /// </summary>
        /// <param name="expansion">A reference to a game expansion.</param>
        /// <param name="instances">The character's completed instances for the game expansion.</param>
        [JsonConstructor]
        public CharacterExpansionInstances(ExpansionReference expansion, CharacterInstance[] instances)
        {
            Expansion = expansion;
            Instances = instances;
        }
    }
}
