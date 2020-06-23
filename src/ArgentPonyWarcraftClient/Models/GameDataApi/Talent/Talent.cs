using Newtonsoft.Json;

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
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the talent.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the tier index for the talent.
        /// </summary>
        [JsonProperty("tier_index")]
        public long TierIndex { get; set; }

        /// <summary>
        /// Gets the column index of the talent.
        /// </summary>
        [JsonProperty("column_index")]
        public long ColumnIndex { get; set; }

        /// <summary>
        /// Gets the level of the talent.
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets the description of the talent.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets a reference to the spell associated with this talent.
        /// </summary>
        [JsonProperty("spell")]
        public SpellReference Spell { get; set; }

        /// <summary>
        /// Gets a reference to the playable class associated with this talent.
        /// </summary>
        [JsonProperty("playable_class")]
        public PlayableClassReference PlayableClass { get; set; }
    }
}
