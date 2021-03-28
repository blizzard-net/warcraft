using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of talents.
    /// </summary>
    public record TalentsIndex
    {
        /// <summary>
        /// Gets links for the index of talents.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to talents.
        /// </summary>
        [JsonPropertyName("talents")]
        public TalentReference[] Talents { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalentsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of talents.</param>
        /// <param name="talents">References to talents.</param>
        [JsonConstructor]
        public TalentsIndex(Links links, TalentReference[] talents)
        {
            Links = links;
            Talents = talents;
        }
    }
}
