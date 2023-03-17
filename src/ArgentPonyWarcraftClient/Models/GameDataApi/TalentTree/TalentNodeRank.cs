namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents a rank of a talent node.
/// </summary>
public record TalentNodeRank
{
    /// <summary>
    /// Gets the rank of the talent node.
    /// </summary>
    [JsonPropertyName("rank")]
    public long Rank { get; init; }

    /// <summary>
    /// Gets the tooltip for the talent node rank.
    /// This property filled when talent node type is ACTIVE or PASSIVE
    /// </summary>
    [JsonPropertyName("tooltip")]
    public TalentNodeTooltip Tooltip { get; init; }

    /// <summary>
    /// Gets the possible tooltips for the talent node rank.
    /// This property filled when talent node type is CHOICE
    /// </summary>
    [JsonPropertyName("choice_of_tooltips")]
    public TalentNodeTooltip[] ChoiceOfTooltips { get; init; }

    /// <summary>
    /// Gets the default number of points in the talent node rank.
    /// </summary>
    [JsonPropertyName("default_points")]
    public long? DefaultPoints { get; init; }
}
