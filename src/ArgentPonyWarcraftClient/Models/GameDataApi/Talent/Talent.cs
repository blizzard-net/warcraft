using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A talent.
    /// </summary>
    public class Talent
    {
        /// <summary>
        /// Gets links for the talent.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets the tier index for the talent.
        /// </summary>
        [JsonPropertyName("tier_index")]
        public int TierIndex { get; set; }

        /// <summary>
        /// Gets the column index of the talent.
        /// </summary>
        [JsonPropertyName("column_index")]
        public int ColumnIndex { get; set; }

        /// <summary>
        /// Gets the level of the talent.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// Gets the description of the talent.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets a reference to the spell associated with this talent.
        /// </summary>
        [JsonPropertyName("spell")]
        public SpellReference Spell { get; set; }

        /// <summary>
        /// Gets a reference to the playable class associated with this talent.
        /// </summary>
        [JsonPropertyName("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }
    }
}
