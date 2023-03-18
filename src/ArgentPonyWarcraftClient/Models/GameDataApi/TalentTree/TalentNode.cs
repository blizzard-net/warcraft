namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents a talent node in a talent tree.
/// </summary>
public record TalentNode
{
    /// <summary>
    /// Gets the ID of the talent node.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; init; }

    /// <summary>
    /// Gets the IDs of the talent nodes that must be unlocked before this talent node can be accessed.
    /// </summary>
    [JsonPropertyName("locked_by")]
    public long[] LockedBy { get; init; }

    /// <summary>
    /// Gets the IDs of the talent nodes that are unlocked by this talent node.
    /// </summary>
    [JsonPropertyName("unlocks")]
    public long[] Unlocks { get; init; }

    /// <summary>
    /// Gets the type of the talent node.
    /// </summary>
    [JsonPropertyName("node_type")]
    public TalentNodeType NodeType { get; init; }

    /// <summary>
    /// Gets the ranks of the talent node.
    /// </summary>
    [JsonPropertyName("ranks")]
    public TalentNodeRank[] Ranks { get; init; }

    /// <summary>
    /// Gets the row where the talent node is displayed in the talent tree.
    /// </summary>
    [JsonPropertyName("display_row")]
    public long DisplayRow { get; init; }

    /// <summary>
    /// Gets the column where the talent node is displayed in the talent tree.
    /// </summary>
    [JsonPropertyName("display_col")]
    public long DisplayColumn { get; init; }

    /// <summary>
    /// Gets the raw X position of the talent node in the talent tree.
    /// </summary>
    [JsonPropertyName("raw_position_x")]
    public long RawPositionX { get; init; }

    /// <summary>
    /// Gets the raw Y position of the talent node in the talent tree.
    /// </summary>
    [JsonPropertyName("raw_position_y")]
    public long RawPositionY { get; init; }
}
