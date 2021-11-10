namespace ArgentPonyWarcraftClient;

/// <summary> 
/// A soulbind selection for a character.
/// </summary>
public record SoulbindSelection
{
    /// <summary>
    /// Gets a reference to the soulbind.
    /// </summary>
    [JsonPropertyName("soulbind")]
    public SoulbindReference Soulbind { get; init; }

    /// <summary>
    /// Gets the soulbinds and associated traits for the character.
    /// </summary>
    [JsonPropertyName("traits")]
    public SoulbindTrait[] Traits { get; init; }

    /// <summary>
    /// Gets a value indicating whether the soulbind is active for this character.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }
}
