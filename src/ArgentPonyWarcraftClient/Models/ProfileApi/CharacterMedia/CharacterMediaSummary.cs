using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the media assets available for a character (such as an avatar render).
    /// </summary>
    public record CharacterMediaSummary
    {
        /// <summary>
        /// Gets the links for the character media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; }

        /// <summary>
        /// Gets media assets associated with the character.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMediaSummary"/> class.
        /// </summary>
        /// <param name="links">The links for the character media.</param>
        /// <param name="character">A reference to the character.</param>
        /// <param name="assets">Media assets associated with the character.</param>
        [JsonConstructor]
        public CharacterMediaSummary(Links links, CharacterReference character, Asset[] assets)
        {
            Links = links;
            Character = character;
            Assets = assets;
        }
    }
}
