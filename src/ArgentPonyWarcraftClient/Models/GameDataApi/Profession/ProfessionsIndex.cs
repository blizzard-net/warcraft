using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of professions.
    /// </summary>
    public record ProfessionsIndex
    {
        /// <summary>
        /// Gets links for the index of professions.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the professions.
        /// </summary>
        [JsonPropertyName("professions")]
        public ProfessionReference[] Professions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfessionsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of professions.</param>
        /// <param name="professions">References to the professions.</param>
        [JsonConstructor]
        public ProfessionsIndex(Links links, ProfessionReference[] professions)
        {
            Links = links;
            Professions = professions;
        }
    }
}
