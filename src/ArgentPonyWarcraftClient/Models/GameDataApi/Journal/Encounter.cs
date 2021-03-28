using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A boss encounter in an dungeon or raid.
    /// </summary>
    public record Encounter
    {
        /// <summary>
        /// Gets links for the encounter.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the encounter.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the encounter.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the description of the encounter.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets the creatures involved in the encounter.
        /// </summary>
        [JsonPropertyName("creatures")]
        public EncounterCreature[] Creatures { get; }

        /// <summary>
        /// Gets the items that can appear as loot from the encounter.
        /// </summary>
        [JsonPropertyName("items")]
        public EncounterItem[] Items { get; }

        /// <summary>
        /// Gets the stages of the encounter.
        /// </summary>
        [JsonPropertyName("sections")]
        public EncounterSection[] Sections { get; }

        /// <summary>
        /// Gets a reference to the dungeon or raid where this encounter takes place.
        /// </summary>
        [JsonPropertyName("instance")]
        public InstanceReference Instance { get; }

        /// <summary>
        /// Gets the category of the instance.
        /// </summary>
        [JsonPropertyName("category")]
        public InstanceCategory Category { get; }

        /// <summary>
        /// Gets the difficulty modes of the encounter.
        /// </summary>
        [JsonPropertyName("modes")]
        public EnumType[] Modes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Encounter"/> class.
        /// </summary>
        /// <param name="links">Links for the encounter.</param>
        /// <param name="id">The ID of the encounter.</param>
        /// <param name="name">The name of the encounter.</param>
        /// <param name="description">The description of the encounter.</param>
        /// <param name="creatures">The creatures involved in the encounter.</param>
        /// <param name="items">The items that can appear as loot from the encounter.</param>
        /// <param name="sections">The stages of the encounter.</param>
        /// <param name="instance">A reference to the dungeon or raid where this encounter takes place.</param>
        /// <param name="category">The category of the instance.</param>
        /// <param name="modes">The difficulty modes of the encounter.</param>
        [JsonConstructor]
        public Encounter(Links links, int id, string name, string description, EncounterCreature[] creatures, EncounterItem[] items, EncounterSection[] sections, InstanceReference instance, InstanceCategory category, EnumType[] modes)
        {
            Links = links;
            Id = id;
            Name = name;
            Description = description;
            Creatures = creatures;
            Items = items;
            Sections = sections;
            Instance = instance;
            Category = category;
            Modes = modes;
        }
    }
}
