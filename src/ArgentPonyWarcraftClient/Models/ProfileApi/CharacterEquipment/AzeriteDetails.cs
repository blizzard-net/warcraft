using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Azerite details for an item.
    /// </summary>
    public record AzeriteDetails
    {
        /// <summary>
        /// Gets the selected azerite powers.
        /// </summary>
        [JsonPropertyName("selected_powers")]
        public SelectedPower[] SelectedPowers { get; }

        /// <summary>
        /// Gets the selected powers description.
        /// </summary>
        [JsonPropertyName("selected_powers_string")]
        public string SelectedPowersString { get; }

        /// <summary>
        /// Gets the percentage remaining to the next level.
        /// </summary>
        [JsonPropertyName("percentage_to_next_level")]
        public float? PercentageToNextLevel { get; }

        /// <summary>
        /// Gets the selected azerite essences.
        /// </summary>
        [JsonPropertyName("selected_essences")]
        public SelectedEssence[] SelectedEssences { get; }

        /// <summary>
        /// Gets the level.
        /// </summary>
        [JsonPropertyName("level")]
        public DescribedValue Level { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzeriteDetails"/> class.
        /// </summary>
        /// <param name="selectedPowers">The selected azerite powers.</param>
        /// <param name="selectedPowersString">The selected powers description.</param>
        /// <param name="percentageToNextLevel">The percentage remaining to the next level.</param>
        /// <param name="selectedEssences">The selected azerite essences.</param>
        /// <param name="level">The level.</param>
        [JsonConstructor]
        public AzeriteDetails(SelectedPower[] selectedPowers, string selectedPowersString, float? percentageToNextLevel, SelectedEssence[] selectedEssences, DescribedValue level)
        {
            SelectedPowers = selectedPowers;
            SelectedPowersString = selectedPowersString;
            PercentageToNextLevel = percentageToNextLevel;
            SelectedEssences = selectedEssences;
            Level = level;
        }
    }
}
