namespace ArgentPonyWarcraftClient;

/// <summary>
/// A character's soulbinds.
/// </summary>
public record CharacterSoulbinds
{
    /// <summary>
    /// Gets links for the character's soulbinds.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links Links { get; init; }

    /// <summary>
    /// Gets a reference to the character.
    /// </summary>
    [JsonPropertyName("character")]
    public CharacterReference Character { get; init; }

    /// <summary>
    /// Gets a reference to the character's chosen covenant.
    /// </summary>
    [JsonPropertyName("chosen_covenant")]
    public CovenantReference ChosenCovenant { get; init; }

    /// <summary>
    /// Gets the renown level for the character with the chosen covenant.
    /// </summary>
    [JsonPropertyName("renown_level")]
    public long RenownLevel { get; init; }

    /// <summary>
    /// Gets the soulbinds for the character.
    /// </summary>
    [JsonPropertyName("soulbinds")]
    public SoulbindSelection[] Soulbinds { get; init; }
}
