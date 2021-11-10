namespace ArgentPonyWarcraftClient;

/// <summary>
/// A power associated with an azerite essence.
/// </summary>
public record Power
{
    /// <summary>
    /// Gets the ID of the azerite essence power.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the rank of the azerite essence power.
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; init; }

    /// <summary>
    /// Gets a reference to the spell that is the main power for this azerite essence.
    /// </summary>
    [JsonPropertyName("main_power_spell")]
    public SpellReference MainPowerSpell { get; init; }

    /// <summary>
    /// Gets a reference to the spell that is the passive power for this azerite essence.
    /// </summary>
    [JsonPropertyName("passive_power_spell")]
    public SpellReference PassivePowerSpell { get; init; }
}
