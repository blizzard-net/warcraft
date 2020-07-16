using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the encounter.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the encounter.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the encounter.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the creatures involved in the encounter.
        /// </summary>
        [JsonProperty("creatures")]
        public EncounterCreature[] Creatures { get; set; }

        /// <summary>
        /// Gets the items that can appear as loot from the encounter.
        /// </summary>
        [JsonProperty("items")]
        public EncounterItem[] Items { get; set; }

        /// <summary>
        /// Gets the stages of the encounter.
        /// </summary>
        [JsonProperty("sections")]
        public EncounterSection[] Sections { get; set; }

        /// <summary>
        /// Gets a reference to the dungeon or raid where this encounter takes place.
        /// </summary>
        [JsonProperty("instance")]
        public InstanceReference Instance { get; set; }

        /// <summary>
        /// Gets the category of the instance.
        /// </summary>
        [JsonProperty("category")]
        public InstanceCategory Category { get; set; }

        /// <summary>
        /// Gets the difficulty modes of the encounter.
        /// </summary>
        [JsonProperty("modes")]
        public EnumType[] Modes { get; set; }
    }
}
