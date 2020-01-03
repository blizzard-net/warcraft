using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A Blizzard user's account details.
    /// </summary>
    public class UserAccount
    {
        /// <summary>
        /// Gets or sets the user's BattleTag.
        /// </summary>
        [JsonProperty("battletag")]
        public string BattleTag { get; set; }

        /// <summary>
        /// Gets or sets the user's account ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
