using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A stage of an encounter in a dungeon or raid.
    /// </summary>
    public partial class EncounterSection
    {
        /// <summary>
        /// Gets the ID of the section.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the title of the section.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets the body text that describes this section of the encounter.
        /// </summary>
        [JsonProperty("body_text", NullValueHandling = NullValueHandling.Ignore)]
        public string BodyText { get; set; }

        /// <summary>
        /// Gets the media associated with this section.
        /// </summary>
        [JsonProperty("creature_display", NullValueHandling = NullValueHandling.Ignore)]
        public Media CreatureDisplay { get; set; }

        /// <summary>
        /// Gets any child sections within this section.
        /// </summary>
        [JsonProperty("sections")]
        public EncounterSection[] Sections { get; set; }
    }
}
