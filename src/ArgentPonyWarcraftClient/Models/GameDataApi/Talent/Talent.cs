using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A talent.
    /// </summary>
    public record Talent
    {
        /// <summary>
        /// Gets links for the talent.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the tier index for the talent.
        /// </summary>
        [JsonPropertyName("tier_index")]
        public int TierIndex { get; }

        /// <summary>
        /// Gets the column index of the talent.
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; }

        /// <summary>
        /// Gets the level of the talent.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets the description of the talent.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets a reference to the spell associated with this talent.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; }

        /// <summary>
        /// Gets a reference to the playable class associated with this talent.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Talent"/> class.
        /// </summary>
        /// <param name="links">Links for the talent.</param>
        /// <param name="id">The ID of the talent.</param>
        /// <param name="tierIndex">The tier index for the talent.</param>
        /// <param name="columnIndex">The column index of the talent.</param>
        /// <param name="level">The level of the talent.</param>
        /// <param name="description">The description of the talent.</param>
        /// <param name="spell">A reference to the spell associated with this talent.</param>
        /// <param name="playableClass">A reference to the playable class associated with this talent.</param>
        [JsonConstructor]
        public Talent(Links links, int id, int tierIndex, int columnIndex, int level, string description, SpellReference spell, PlayableClassReference playableClass)
        {
            Links = links;
            Id = id;
            TierIndex = tierIndex;
            ColumnIndex = columnIndex;
            Level = level;
            Description = description;
            Spell = spell;
            PlayableClass = playableClass;
        }
    }
}
