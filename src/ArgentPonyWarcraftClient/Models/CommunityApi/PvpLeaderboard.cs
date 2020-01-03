using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP leaderboard.
    /// </summary>
    public class PvpLeaderboard
    {
        /// <summary>
        /// Gets or sets the characters.
        /// </summary>
        [JsonProperty("rows")]
        public IList<PvpCharacter> Characters { get; set; }
    }
}
