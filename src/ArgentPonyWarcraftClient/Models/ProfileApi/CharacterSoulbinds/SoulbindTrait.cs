namespace ArgentPonyWarcraftClient;

/// <summary>
/// Character traits associated with a soulbind.
/// </summary>
public record SoulbindTrait
{
    /// <summary>
    /// Gets a reference to a tech talent selected as a trait for this character.
    /// </summary>
    [JsonPropertyName("trait")]
    public TechTalentReference Trait { get; init; }

    /// <summary>
    /// Gets the tier for this trait.
    /// </summary>
    [JsonPropertyName("tier")]
    public long Tier { get; init; }

    /// <summary>
    /// Gets the display order of this trait.
    /// </summary>
    [JsonPropertyName("display_order")]
    public long DisplayOrder { get; init; }

    /// <summary>
    /// Gets a conduit socket for this character.
    /// </summary>
    [JsonPropertyName("conduit_socket")]
    public ConduitSocketTrait ConduitSocket { get; init; }
}
