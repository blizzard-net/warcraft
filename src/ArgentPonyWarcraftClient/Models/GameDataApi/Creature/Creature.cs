using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A creature.
    /// </summary>
    public record Creature
    {
        /// <summary>
        /// Gets links for the creature.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the creature.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the creature.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the type of the creature.
        /// </summary>
        [JsonPropertyName("type")]
        public CreatureTypeReference Type { get; }

        /// <summary>
        /// Gets the family of the creature.
        /// </summary>
        [JsonPropertyName("family")]
        public CreatureFamilyReference Family { get; }

        /// <summary>
        /// Gets the creature display media for this creature.
        /// </summary>
        [JsonPropertyName("creature_displays")]
        public Media[] CreatureDisplays { get; }

        /// <summary>
        /// Gets a value indicating whether the creature can be tamed.
        /// </summary>
        [JsonPropertyName("is_tameable")]
        public bool IsTameable { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Creature"/> class.
        /// </summary>
        /// <param name="links">Links for the creature.</param>
        /// <param name="id">The ID of the creature.</param>
        /// <param name="name">The name of the creature.</param>
        /// <param name="type">The type of the creature.</param>
        /// <param name="family">The family of the creature.</param>
        /// <param name="creatureDisplays">The creature display media for this creature.</param>
        /// <param name="isTameable">A value indicating whether the creature can be tamed.</param>
        [JsonConstructor]
        public Creature(Links links, int id, string name, CreatureTypeReference type, CreatureFamilyReference family, Media[] creatureDisplays, bool isTameable)
        {
            Links = links;
            Id = id;
            Name = name;
            Type = type;
            Family = family;
            CreatureDisplays = creatureDisplays;
            IsTameable = isTameable;
        }
    }
}
