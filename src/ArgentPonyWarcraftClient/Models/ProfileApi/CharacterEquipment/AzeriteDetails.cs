namespace ArgentPonyWarcraftClient;

/// <summary>
/// Azerite details for an item.
/// </summary>
public record AzeriteDetails
{
    /// <summary>
    /// Gets the selected azerite powers.
    /// </summary>
    [JsonPropertyName("selected_powers")]
    public SelectedPower[] SelectedPowers { get; init; }

    /// <summary>
    /// Gets the selected powers description.
    /// </summary>
    [JsonPropertyName("selected_powers_string")]
    public string SelectedPowersString { get; init; }

    /// <summary>
    /// Gets the percentage remaining to the next level.
    /// </summary>
    [JsonPropertyName("percentage_to_next_level")]
    public float? PercentageToNextLevel { get; init; }

    /// <summary>
    /// Gets the selected azerite essences.
    /// </summary>
    [JsonPropertyName("selected_essences")]
    public SelectedEssence[] SelectedEssences { get; init; }

    /// <summary>
    /// Gets the level.
    /// </summary>
    [JsonPropertyName("level")]
    public DescribedValue Level { get; init; }
}
