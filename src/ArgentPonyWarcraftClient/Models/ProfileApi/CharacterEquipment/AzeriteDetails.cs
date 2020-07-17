using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Azerite details for an item.
    /// </summary>
    public class AzeriteDetails
    {
        /// <summary>
        /// Gets the selected azerite powers.
        /// </summary>
        [JsonPropertyName("selected_powers")]
        public SelectedPower[] SelectedPowers { get; set; }

        /// <summary>
        /// Gets the selected powers description.
        /// </summary>
        [JsonPropertyName("selected_powers_string")]
        public string SelectedPowersString { get; set; }

        /// <summary>
        /// Gets the percentage remaining to the next level.
        /// </summary>
        [JsonPropertyName("percentage_to_next_level")]
        public double? PercentageToNextLevel { get; set; }

        /// <summary>
        /// Gets the selected azerite essences.
        /// </summary>
        [JsonPropertyName("selected_essences")]
        public SelectedEssence[] SelectedEssences { get; set; }

        /// <summary>
        /// Gets the level.
        /// </summary>
        [JsonPropertyName("level")]
        public DescribedValue Level { get; set; }
    }
}
