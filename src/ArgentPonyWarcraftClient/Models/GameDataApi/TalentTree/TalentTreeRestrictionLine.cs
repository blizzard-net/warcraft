namespace ArgentPonyWarcraftClient;

/// <summary>
/// Represents a restriction line for a talent tree.
/// </summary>
public record TalentTreeRestrictionLine
{
    /// <summary>
    /// Gets the number of points required to unlock the restriction line.
    /// </summary>
    [JsonPropertyName("required_points")]
    public long RequiredPoints { get; init; }

    /// <summary>
    /// Gets the row where the restriction line is located.
    /// </summary>
    [JsonPropertyName("restricted_row")]
    public double RestrictedRow { get; init; }

    /// <summary>
    /// Gets a value indicating whether the restriction line is for the class or specialization.
    /// </summary>
    [JsonPropertyName("is_for_class")]
    public bool IsForClass { get; init; }
}
