using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of quest areas.
    /// </summary>
    public class QuestAreasIndex
    {
        /// <summary>
        /// Gets links for the index of quest areas.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the quest areas.
        /// </summary>
        [JsonProperty("areas")]
        public QuestAreaReference[] Areas { get; set; }
    }
}
