using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of talents.
    /// </summary>
    public class TalentsIndex
    {
        /// <summary>
        /// Gets links for the index of talents.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to talents.
        /// </summary>
        [JsonProperty("talents")]
        public TalentReference[] Talents { get; set; }
    }
}
