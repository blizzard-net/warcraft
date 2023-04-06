namespace ArgentPonyWarcraftClient;

/// <summary>
/// Loadout for specialization
/// </summary>
public record SpecializationLoadout
{
    /// <summary>
    /// Is the loadout currently active?
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }

    /// <summary>
    /// Code for the load out.
    /// </summary>
    [JsonPropertyName("talent_loadout_code")]
    public string TalentLoadoutCode { get; init; }

    /// <summary>
    /// Gets the selected class talents.
    /// </summary>
    [JsonPropertyName("selected_class_talents")]
    public LoadoutTalent[] SelectedClassTalents { get; init; }

    /// <summary>
    /// Gets the selected spec talents.
    /// </summary>
    [JsonPropertyName("selected_spec_talents")]
    public LoadoutTalent[] SelectedSpecTalents { get; init; }
}
