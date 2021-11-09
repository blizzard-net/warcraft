namespace ArgentPonyWarcraftClient;

/// <summary>
/// Covenant Progress
/// </summary>
public class CovenantProgress
{
    /// <summary>
    /// Gets chosen covenant for the character.
    /// </summary>
    [JsonPropertyName("chosen_covenant")]
    public CovenantReference ChosenCovenant { get; set; }

    /// <summary>
    /// Gets the covenant renown level for the character.
    /// </summary>
    [JsonPropertyName("renown_level")]
    public int RenownLevel { get; set; }

    /// <summary>
    /// Gets a link to the character's soulbinds.
    /// </summary>
    [JsonPropertyName("soulbinds")]
    public Self Soulbinds { get; set; }
}
