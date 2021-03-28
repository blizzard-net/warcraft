using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of instances.
    /// </summary>
    public class JournalInstancesIndex
    {
        /// <summary>
        /// Gets links for the index of instances.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the instances.
        /// </summary>
        [JsonPropertyName("instances")]
        public InstanceReference[] Instances { get; set; }
    }
}
