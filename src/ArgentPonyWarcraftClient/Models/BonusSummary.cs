using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A bonus summary.
    /// </summary>
    public class BonusSummary
    {
        /// <summary>
        /// Gets or sets the default bonus lists.
        /// </summary>
        [JsonProperty("defaultBonusLists")]
        public IList<int> DefaultBonusLists { get; set; }

        /// <summary>
        /// Gets or sets the chance bonus lists.
        /// </summary>
        [JsonProperty("chanceBonusLists")]
        public IList<int> ChanceBonusLists { get; set; }

        /// <summary>
        /// Gets or sets the bonus chances.
        /// </summary>
        [JsonProperty("bonusChances")]
        public IList<int> BonusChances { get; set; }
    }
}
