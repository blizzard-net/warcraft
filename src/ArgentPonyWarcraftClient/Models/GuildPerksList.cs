using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A guild perks list.
    /// </summary>
    public class GuildPerksList
    {
        /// <summary>
        /// Gets or sets the guild perks.
        /// </summary>
        [JsonProperty("perks")]
        public IList<Perk> Perks { get; set; }
    }
}
