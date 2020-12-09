using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of tech talent trees.
    /// </summary>
    public class TechTalentTreesIndex
    {
        /// <summary>
        /// Gets links for the index of tech talent trees.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// The collection of tech talent tree references.
        /// </summary>
        [JsonPropertyName("talent_trees")]
        public TechTalentReference[] TalentTrees { get; set; }
    }
}
