using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of playable classes.
    /// </summary>
    public record PlayableClassesIndex
    {
        /// <summary>
        /// Gets links for the index of playable classes.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the playable classes.
        /// </summary>
        [JsonPropertyName("classes")]
        public PlayableClassReference[] Classes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayableClassesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of playable classes.</param>
        /// <param name="classes">References to the playable classes.</param>
        [JsonConstructor]
        public PlayableClassesIndex(Links links, PlayableClassReference[] classes)
        {
            Links = links;
            Classes = classes;
        }
    }
}
