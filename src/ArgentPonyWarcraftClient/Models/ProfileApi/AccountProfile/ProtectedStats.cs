using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Protected statistics for a character.
    /// </summary>
    public record ProtectedStats
    {
        /// <summary>
        /// Gets the total number of deaths for the character.
        /// </summary>
        [JsonPropertyName("total_number_deaths")]
        public int TotalNumberDeaths { get; }

        /// <summary>
        /// Gets the total gold gained by the character.
        /// </summary>
        [JsonPropertyName("total_gold_gained")]
        public long TotalGoldGained { get; }

        /// <summary>
        /// Gets the total gold lost by the character.
        /// </summary>
        [JsonPropertyName("total_gold_lost")]
        public long TotalGoldLost { get; }

        /// <summary>
        /// Gets the total item value gained by the character.
        /// </summary>
        [JsonPropertyName("total_item_value_gained")]
        public long TotalItemValueGained { get; }

        /// <summary>
        /// Gets the number of deaths at this level for the character.
        /// </summary>
        [JsonPropertyName("level_number_deaths")]
        public int LevelNumberDeaths { get; }

        /// <summary>
        /// Gets the gold gained at this level by the character.
        /// </summary>
        [JsonPropertyName("level_gold_gained")]
        public long LevelGoldGained { get; }

        /// <summary>
        /// Gets the gold lost at this level by the character.
        /// </summary>
        [JsonPropertyName("level_gold_lost")]
        public long LevelGoldLost { get; }

        /// <summary>
        /// Gets the item value gained at this level by the character.
        /// </summary>
        [JsonPropertyName("level_item_value_gained")]
        public long LevelItemValueGained { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedStats"/> class.
        /// </summary>
        /// <param name="totalNumberDeaths">The total number of deaths for the character.</param>
        /// <param name="totalGoldGained">The total gold gained by the character.</param>
        /// <param name="totalGoldLost">The total gold lost by the character.</param>
        /// <param name="totalItemValueGained">The total item value gained by the character.</param>
        /// <param name="levelNumberDeaths">The number of deaths at this level for the character.</param>
        /// <param name="levelGoldGained">The gold gained at this level by the character.</param>
        /// <param name="levelGoldLost">The gold lost at this level by the character.</param>
        /// <param name="levelItemValueGained">The item value gained at this level by the character.</param>
        [JsonConstructor]
        public ProtectedStats(int totalNumberDeaths, long totalGoldGained, long totalGoldLost, long totalItemValueGained, int levelNumberDeaths, long levelGoldGained, long levelGoldLost, long levelItemValueGained)
        {
            TotalNumberDeaths = totalNumberDeaths;
            TotalGoldGained = totalGoldGained;
            TotalGoldLost = totalGoldLost;
            TotalItemValueGained = totalItemValueGained;
            LevelNumberDeaths = levelNumberDeaths;
            LevelGoldGained = levelGoldGained;
            LevelGoldLost = levelGoldLost;
            LevelItemValueGained = levelItemValueGained;
        }
    }
}
