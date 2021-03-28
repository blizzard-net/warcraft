using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quests.
    /// </summary>
    public record QuestsIndex
    {
        /// <summary>
        /// Gets links for the index of quests.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the quest categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public Self Categories { get; }

        /// <summary>
        /// Gets a reference to the quest areas.
        /// </summary>
        [JsonPropertyName("areas")]
        public Self Areas { get; }

        /// <summary>
        /// Gets a reference to the quest types.
        /// </summary>
        [JsonPropertyName("types")]
        public Self Types { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestsIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of quests.</param>
        /// <param name="categories">A reference to the quest categories.</param>
        /// <param name="areas">A reference to the quest areas.</param>
        /// <param name="types">A reference to the quest types.</param>
        [JsonConstructor]
        public QuestsIndex(Links links, Self categories, Self areas, Self types)
        {
            Links = links;
            Categories = categories;
            Areas = areas;
            Types = types;
        }
    }
}
