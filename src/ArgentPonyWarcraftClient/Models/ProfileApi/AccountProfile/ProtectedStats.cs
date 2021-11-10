namespace ArgentPonyWarcraftClient;

/// <summary>
/// Protected statistics for a character.
/// </summary>
public record ProtectedStats
{
    /// <summary>
    /// Gets the total number of deaths for the character.
    /// </summary>
    [JsonPropertyName("total_number_deaths")]
    public int TotalNumberDeaths { get; init; }

    /// <summary>
    /// Gets the total gold gained by the character.
    /// </summary>
    [JsonPropertyName("total_gold_gained")]
    public long TotalGoldGained { get; init; }

    /// <summary>
    /// Gets the total gold lost by the character.
    /// </summary>
    [JsonPropertyName("total_gold_lost")]
    public long TotalGoldLost { get; init; }

    /// <summary>
    /// Gets the total item value gained by the character.
    /// </summary>
    [JsonPropertyName("total_item_value_gained")]
    public long TotalItemValueGained { get; init; }

    /// <summary>
    /// Gets the number of deaths at this level for the character.
    /// </summary>
    [JsonPropertyName("level_number_deaths")]
    public int LevelNumberDeaths { get; init; }

    /// <summary>
    /// Gets the gold gained at this level by the character.
    /// </summary>
    [JsonPropertyName("level_gold_gained")]
    public long LevelGoldGained { get; init; }

    /// <summary>
    /// Gets the gold lost at this level by the character.
    /// </summary>
    [JsonPropertyName("level_gold_lost")]
    public long LevelGoldLost { get; init; }

    /// <summary>
    /// Gets the item value gained at this level by the character.
    /// </summary>
    [JsonPropertyName("level_item_value_gained")]
    public long LevelItemValueGained { get; init; }
}
