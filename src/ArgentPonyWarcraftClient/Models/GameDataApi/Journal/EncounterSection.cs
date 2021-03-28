using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A stage of an encounter in a dungeon or raid.
    /// </summary>
    public record EncounterSection
    {
        /// <summary>
        /// Gets the ID of the section.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the title of the section.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; }

        /// <summary>
        /// Gets the body text that describes this section of the encounter.
        /// </summary>
        [JsonPropertyName("body_text")]
        public string BodyText { get; }

        /// <summary>
        /// Gets the media associated with this section.
        /// </summary>
        [JsonPropertyName("creature_display")]
        public Media CreatureDisplay { get; }

        /// <summary>
        /// Gets any child sections within this section.
        /// </summary>
        [JsonPropertyName("sections")]
        public EncounterSection[] Sections { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncounterSection"/> class.
        /// </summary>
        /// <param name="id">The ID of the section.</param>
        /// <param name="title">The title of the section.</param>
        /// <param name="bodyText">The body text that describes this section of the encounter.</param>
        /// <param name="creatureDisplay">The media associated with this section.</param>
        /// <param name="sections">Any child sections within this section.</param>
        [JsonConstructor]
        public EncounterSection(int id, string title, string bodyText, Media creatureDisplay, EncounterSection[] sections)
        {
            Id = id;
            Title = title;
            BodyText = bodyText;
            CreatureDisplay = creatureDisplay;
            Sections = sections;
        }
    }
}
