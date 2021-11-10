namespace ArgentPonyWarcraftClient;

/// <summary>
/// An index of PvP rewards for a PvP season.
/// </summary>
public record PvpRewardsIndex
{
    /// <summary>
    /// Gets links for the PvP rewards.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the PvP season.
    /// </summary>
    [JsonPropertyName("season")]
    public PvpSeasonReference Season { get; init; }

    /// <summary>
    /// Gets the rewards for the PvP season.
    /// </summary>
    [JsonPropertyName("rewards")]
    public PvpSeasonReward[] Rewards { get; init; }
}
