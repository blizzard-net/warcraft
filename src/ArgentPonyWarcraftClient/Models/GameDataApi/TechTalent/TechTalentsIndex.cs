using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of tech talents.
    /// </summary>
    public record TechTalentsIndex
    {
        /// <summary>
        /// Gets links for the index of tech talents.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the references to the tech talents.
        /// </summary>
        [JsonPropertyName("talents")]
        public TechTalentReference[] Talents { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechTalentsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of tech talents.</param>
        /// <param name="talents">The references to the tech talents.</param>
        [JsonConstructor]
        public TechTalentsIndex(Links links, TechTalentReference[] talents)
        {
            Links = links;
            Talents = talents;
        }
    }
}
