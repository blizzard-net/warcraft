using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reward for a PvP season.
    /// </summary>
    public record PvpSeasonReward
    {
        /// <summary>
        /// Gets the PvP bracket for the reward.
        /// </summary>
        [JsonPropertyName("bracket")]
        public Bracket Bracket { get; }

        /// <summary>
        /// Gets a reference to the achievement associated with this reward.
        /// </summary>
        [JsonPropertyName("achievement")]
        public AchievementReference Achievement { get; }

        /// <summary>
        /// Gets the PvP rating cutoff for this reward.
        /// </summary>
        [JsonPropertyName("rating_cutoff")]
        public int RatingCutoff { get; }

        /// <summary>
        /// Gets the faction (Alliance or Horde) for this reward.
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PvpSeasonReward"/> class.
        /// </summary>
        /// <param name="bracket">The PvP bracket for the reward.</param>
        /// <param name="achievement">A reference to the achievement associated with this reward.</param>
        /// <param name="ratingCutoff">The PvP rating cutoff for this reward.</param>
        /// <param name="faction">The faction (Alliance or Horde) for this reward.</param>
        [JsonConstructor]
        public PvpSeasonReward(Bracket bracket, AchievementReference achievement, int ratingCutoff, EnumType faction)
        {
            Bracket = bracket;
            Achievement = achievement;
            RatingCutoff = ratingCutoff;
            Faction = faction;
        }
    }
}
