namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents an index of talent trees.
/// </summary>
public record TalentTreeIndex
{
    /// <summary>
    /// Gets the links for the talent tree.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    ///  Gets an array of references to the talent trees associated with this specialization.
    /// </summary>
    [JsonPropertyName("spec_talent_trees")]
    public TalentTreeReference[] SpecTalentTrees { get; init; }

    /// <summary>
    /// Gets an array of references to the talent trees associated with this class.
    /// </summary>
    [JsonPropertyName("class_talent_trees")]
    public TalentTreeReference[] ClassTalentTrees { get; init; }
}
