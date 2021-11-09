namespace ArgentPonyWarcraftClient;

/// <summary>
/// A guild member.
/// </summary>
public record GuildMember
{
    /// <summary>
    /// Gets the character.
    /// </summary>
    [JsonPropertyName("character")]
    public GuildCharacter Character { get; init; }

    /// <summary>
    /// Gets the character's rank in the guild.
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; init; }
}
