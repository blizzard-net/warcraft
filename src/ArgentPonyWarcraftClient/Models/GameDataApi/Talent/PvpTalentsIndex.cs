using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of PvP talents.
    /// </summary>
    public class PvpTalentsIndex
    {
        /// <summary>
        /// Gets links for the index of PvP talents.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to PvP talents.
        /// </summary>
        [JsonProperty("pvp_talents")]
        public PvpTalentReference[] PvpTalents { get; set; }
    }
}
