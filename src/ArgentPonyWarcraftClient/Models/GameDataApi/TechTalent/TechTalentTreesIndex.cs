using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of tech talent trees.
    /// </summary>
    public record TechTalentTreesIndex
    {
        /// <summary>
        /// Gets links for the index of tech talent trees.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// The collection of tech talent tree references.
        /// </summary>
        [JsonPropertyName("talent_trees")]
        public TechTalentReference[] TalentTrees { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechTalentTreesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of tech talent trees.</param>
        /// <param name="talentTrees">Links for the index of tech talent trees.</param>
        [JsonConstructor]
        public TechTalentTreesIndex(Links links, TechTalentReference[] talentTrees)
        {
            Links = links;
            TalentTrees = talentTrees;
        }
    }
}
