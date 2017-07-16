using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A list of challenges.
    /// </summary>
    public class ChallengeList
    {
        /// <summary>
        /// Gets or sets the list of challenges.
        /// </summary>
        [JsonProperty("challenge")]
        public IList<Challenge> Challenges { get; set; }
    }
}
