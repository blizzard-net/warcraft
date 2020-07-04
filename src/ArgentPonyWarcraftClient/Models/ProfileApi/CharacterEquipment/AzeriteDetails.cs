using Newtonsoft.Json;

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
        [JsonProperty("selected_powers", NullValueHandling = NullValueHandling.Ignore)]
        public SelectedPower[] SelectedPowers { get; set; }

        /// <summary>
        /// Gets the selected powers description.
        /// </summary>
        [JsonProperty("selected_powers_string", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectedPowersString { get; set; }

        /// <summary>
        /// Gets the percentage remaining to the next level.
        /// </summary>
        [JsonProperty("percentage_to_next_level", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentageToNextLevel { get; set; }

        /// <summary>
        /// Gets the selected azerite essences.
        /// </summary>
        [JsonProperty("selected_essences", NullValueHandling = NullValueHandling.Ignore)]
        public SelectedEssence[] SelectedEssences { get; set; }

        /// <summary>
        /// Gets the level.
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public DescribedValue Level { get; set; }
    }
}
