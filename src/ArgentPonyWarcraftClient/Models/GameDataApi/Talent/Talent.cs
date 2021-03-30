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
        public Links Links { get; init; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets the tier index for the talent.
        /// </summary>
        [JsonPropertyName("tier_index")]
        public int TierIndex { get; init; }

        /// <summary>
        /// Gets the column index of the talent.
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; init; }

        /// <summary>
        /// Gets the level of the talent.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; init; }

        /// <summary>
        /// Gets the description of the talent.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// Gets a reference to the spell associated with this talent.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; init; }

        /// <summary>
        /// Gets a reference to the playable class associated with this talent.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; init; }
    }
}
