using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A stage of an encounter in a dungeon or raid.
    /// </summary>
    public class EncounterSection
    {
        /// <summary>
        /// Gets the ID of the section.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the title of the section.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets the body text that describes this section of the encounter.
        /// </summary>
        [JsonPropertyName("body_text")]
        public string BodyText { get; set; }

        /// <summary>
        /// Gets the media associated with this section.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public Media CreatureDisplay { get; set; }

        /// <summary>
        /// Gets any child sections within this section.
        /// </summary>
        [JsonPropertyName("sections")]
        public EncounterSection[] Sections { get; set; }
    }
}
