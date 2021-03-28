using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A game expansion.
    /// </summary>
    public record JournalExpansion
    {
        /// <summary>
        /// Gets links for the expansion.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the expansion.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the expansion.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the dungeons that belong to the expansion.
        /// </summary>
        [JsonPropertyName("dungeons")]
        public InstanceReference[] Dungeons { get; }

        /// <summary>
        /// Gets the raids that belong to the expansion.
        /// </summary>
        [JsonPropertyName("raids")]
        public InstanceReference[] Raids { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JournalExpansion"/> class.
        /// </summary>
        /// <param name="links">Links for the expansion.</param>
        /// <param name="id">The ID of the expansion.</param>
        /// <param name="name">The name of the expansion.</param>
        /// <param name="dungeons">The dungeons that belong to the expansion.</param>
        /// <param name="raids">The raids that belong to the expansion.</param>
        [JsonConstructor]
        public JournalExpansion(Links links, int id, string name, InstanceReference[] dungeons, InstanceReference[] raids)
        {
            Links = links;
            Id = id;
            Name = name;
            Dungeons = dungeons;
            Raids = raids;
        }
    }
}
