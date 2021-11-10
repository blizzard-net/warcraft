namespace ArgentPonyWarcraftClient;

/// <summary>
/// Criteria for completing an achievement.
/// </summary>
public record Criteria
{
    /// <summary>
    /// Gets the ID of the related achievement that is a criterion for completing the parent achievement.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets a value indicating whether the criterion achievment has been completed.
    /// </summary>
    [JsonPropertyName("is_completed")]
    public bool IsCompleted { get; init; }

    /// <summary>
    /// Gets child criteria of the criterion achievment, if any.
    /// </summary>
    [JsonPropertyName("child_criteria")]
    public Criteria[] ChildCriteria { get; init; }

    /// <summary>
    /// Gets an amount associated with this criterion achievment, if any.
    /// </summary>
    [JsonPropertyName("amount")]
    public ulong? Amount { get; init; }
}
