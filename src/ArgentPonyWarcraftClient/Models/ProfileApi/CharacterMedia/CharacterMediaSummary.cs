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
        /// Gets a URL for a render of the character's avatar.
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// Gets a URL for a render of the character bust.
        /// </summary>
        [JsonPropertyName("bust_url")]
        public Uri BustUrl { get; set; }

        /// <summary>
        /// Gets a URL for the main render of the character.
        /// </summary>
        [JsonPropertyName("render_url")]
        public Uri RenderUrl { get; set; }
    }
}
