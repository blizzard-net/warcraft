using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of instances.
    /// </summary>
    public record JournalInstancesIndex
    {
        /// <summary>
        /// Gets links for the index of instances.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the instances.
        /// </summary>
        [JsonPropertyName("instances")]
        public InstanceReference[] Instances { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JournalInstancesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of instances.</param>
        /// <param name="instances">References to the instances.</param>
        [JsonConstructor]
        public JournalInstancesIndex(Links links, InstanceReference[] instances)
        {
            Links = links;
            Instances = instances;
        }
    }
}
