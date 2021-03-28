using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// The status of a player character.
    /// </summary>
    public record CharacterStatus
    {
        /// <summary>
        /// Gets links for the character status.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether the character is valid.
        /// </summary>
        [JsonPropertyName("is_valid")]
        public bool IsValid { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterStatus"/> class.
        /// </summary>
        /// <param name="links">Links for the character status.</param>
        /// <param name="id">The ID of the character.</param>
        /// <param name="isValid">A value indicating whether the character is valid.</param>
        [JsonConstructor]
        public CharacterStatus(Links links, int id, bool isValid)
        {
            Links = links;
            Id = id;
            IsValid = isValid;
        }
    }
}
