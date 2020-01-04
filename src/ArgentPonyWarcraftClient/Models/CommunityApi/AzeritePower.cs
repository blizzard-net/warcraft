using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// An Azerite power.
    /// </summary>
    public class AzeritePower
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the tier.
        /// </summary>
        [JsonProperty("tier")]
        public int Tier { get; set; }

        /// <summary>
        /// Gets or sets the spell ID.
        /// </summary>
        [JsonProperty("spellId")]
        public int SpellId { get; set; }

        /// <summary>
        /// Gets or sets the bonus list ID.
        /// </summary>
        [JsonProperty("bonusListId")]
        public int BonusListId { get; set; }
    }
}
