using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Character raid progression.
    /// </summary>
    public class Progression
    {
        /// <summary>
        /// Gets or sets progression information for raids.
        /// </summary>
        [JsonProperty("raids")]
        public IList<Raid> Raids { get; set; }
    }
}
