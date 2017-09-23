using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of guild achievements.
    /// </summary>
    public class GuildAchievementsList
    {
        /// <summary>
        /// Gets or sets the guild achievements.
        /// </summary>
        [JsonProperty("achievements")]
        public IList<AchievementCategory> Achievements { get; set; }
    }
}
