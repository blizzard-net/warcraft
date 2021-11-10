namespace ArgentPonyWarcraftClient;

/// <summary>
/// A covenant.
/// </summary>
public record Covenant
{
    /// <summary>
    /// Gets the key for this covenant.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets the Id for this covenant.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the name for this covenant.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Gets the description for this covenant.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    /// Gets the signature ability for this covenant.
    /// </summary>
    [JsonPropertyName("signature_ability")]
    public CovenantSignatureAbility SignatureAbility { get; init; }

    /// <summary>
    /// Gets the various class abilities for this covenant.
    /// </summary>
    [JsonPropertyName("class_abilities")]
    public CovenantClassAbility[] ClassAbilities { get; init; }

    /// <summary>
    /// Gets the soulbind references for this covenant.
    /// </summary>
    [JsonPropertyName("soulbinds")]
    public SoulbindReference[] Soulbinds { get; init; }

    /// <summary>
    /// Gets the renown rewards for this covenant.
    /// </summary>
    [JsonPropertyName("renown_rewards")]
    public RenownReward[] RenownRewards { get; init; }

    /// <summary>
    /// Gets the media reference for this covenant.
    /// </summary>
    [JsonPropertyName("media")]
    public CovenantMediaReference Media { get; init; }
}
