using System.Text.Json.Serialization;

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
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the quest categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public Self Categories { get; set; }

        /// <summary>
        /// Gets a reference to the quest areas.
        /// </summary>
        [JsonPropertyName("areas")]
        public Self Areas { get; set; }

        /// <summary>
        /// Gets a reference to the quest types.
        /// </summary>
        [JsonPropertyName("types")]
        public Self Types { get; set; }
    }
}
