using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reward for a PvP season.
    /// </summary>
    public class PvpSeasonReward
    {
        /// <summary>
        /// Gets the PvP bracket for the reward.
        /// </summary>
        [JsonProperty("bracket")]
        public Bracket Bracket { get; set; }

        /// <summary>
        /// Gets a reference to the achievement associated with this reward.
        /// </summary>
        [JsonProperty("achievement")]
        public AchievementReference Achievement { get; set; }

        /// <summary>
        /// Gets the PvP rating cutoff for this reward.
        /// </summary>
        [JsonProperty("rating_cutoff")]
        public long RatingCutoff { get; set; }

        /// <summary>
        /// Gets the faction (Alliance or Horde) for this reward.
        /// </summary>
        [JsonProperty("faction")]
        public EnumType Faction { get; set; }
    }
}
