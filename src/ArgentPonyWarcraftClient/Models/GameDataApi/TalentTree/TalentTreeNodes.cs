namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents all talent tree nodes as well as links to associated playable specializations for a specific talent tree.
/// </summary>
public record TalentTreeNodes
{
    /// <summary>
    /// Gets the links related to the talent tree.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; set; }

    /// <summary>
    /// Gets the ID of the talent tree.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets a reference to associated playable specializations given a talent tree.
    /// </summary>
    [JsonPropertyName("spec_talent_trees")]
    public TalentTreeReference[] SpecTalentTrees { get; set; }

    /// <summary>
    /// Gets the all talent nodes in the talent tree.
    /// </summary>
    [JsonPropertyName("talent_nodes")]
    public TalentNode[] TalentNodes { get; set; }
}
