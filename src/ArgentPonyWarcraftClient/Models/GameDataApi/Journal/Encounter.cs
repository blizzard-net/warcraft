using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A boss encounter in an dungeon or raid.
    /// </summary>
    public class Encounter
    {
        /// <summary>
        /// Gets links for the encounter.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the encounter.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the encounter.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the encounter.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the creatures involved in the encounter.
        /// </summary>
        [JsonPropertyName("creatures")]
        public EncounterCreature[] Creatures { get; set; }

        /// <summary>
        /// Gets the items that can appear as loot from the encounter.
        /// </summary>
        [JsonPropertyName("items")]
        public EncounterItem[] Items { get; set; }

        /// <summary>
        /// Gets the stages of the encounter.
        /// </summary>
        [JsonPropertyName("sections")]
        public EncounterSection[] Sections { get; set; }

        /// <summary>
        /// Gets a reference to the dungeon or raid where this encounter takes place.
        /// </summary>
        [JsonPropertyName("instance")]
        public InstanceReference Instance { get; set; }

        /// <summary>
        /// Gets the category of the instance.
        /// </summary>
        [JsonPropertyName("category")]
        public InstanceCategory Category { get; set; }

        /// <summary>
        /// Gets the difficulty modes of the encounter.
        /// </summary>
        [JsonPropertyName("modes")]
        public EnumType[] Modes { get; set; }
    }
}
