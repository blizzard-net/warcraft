using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An index of instances.
    /// </summary>
    public class JournalInstancesIndex
    {
        /// <summary>
        /// Gets links for the index of instances.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the instances.
        /// </summary>
        [JsonProperty("instances")]
        public InstanceReference[] Instances { get; set; }
    }
}
