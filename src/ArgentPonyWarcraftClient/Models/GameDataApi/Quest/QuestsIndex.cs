using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quests.
    /// </summary>
    public class QuestsIndex
    {
        /// <summary>
        /// Gets links for the index of quests.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the quest categories.
        /// </summary>
        [JsonProperty("categories")]
        public Self Categories { get; set; }

        /// <summary>
        /// Gets a reference to the quest areas.
        /// </summary>
        [JsonProperty("areas")]
        public Self Areas { get; set; }

        /// <summary>
        /// Gets a reference to the quest types.
        /// </summary>
        [JsonProperty("types")]
        public Self Types { get; set; }
    }
}
