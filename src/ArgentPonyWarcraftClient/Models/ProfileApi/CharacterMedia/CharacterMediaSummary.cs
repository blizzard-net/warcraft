using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A summary of the media assets available for a character (such as an avatar render).
    /// </summary>
    public class CharacterMediaSummary
    {
        /// <summary>
        /// Gets the links for the character media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets a reference to the character.
        /// </summary>
        [JsonPropertyName("character")]
        public CharacterReference Character { get; set; }

        /// <summary>
        /// Gets media assets associated with the character.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; set; }
    }
}
