using System.Text.Json.Serialization;

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
        [JsonPropertyName("bracket")]
        public Bracket Bracket { get; set; }

        /// <summary>
        /// Gets a reference to the achievement associated with this reward.
        /// </summary>
        [JsonPropertyName("achievement")]
        public AchievementReference Achievement { get; set; }

        /// <summary>
        /// Gets the PvP rating cutoff for this reward.
        /// </summary>
        [JsonPropertyName("rating_cutoff")]
        public long RatingCutoff { get; set; }

        /// <summary>
        /// Gets the faction (Alliance or Horde) for this reward.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }
    }
}
