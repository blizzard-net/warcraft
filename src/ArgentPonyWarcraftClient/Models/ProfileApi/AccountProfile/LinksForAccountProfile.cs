using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Links associated with a user profile.
    /// </summary>
    public class LinksForAccountProfile
    {
        /// <summary>
        /// Gets a self-reference.
        /// </summary>
        [JsonPropertyName("self")]
        public Self Self { get; set; }

        /// <summary>
        /// Gets a link to the user.
        /// </summary>
        [JsonPropertyName("user")]
        public Self User { get; set; }

        /// <summary>
        /// Gets a link to the profile.
        /// </summary>
        [JsonPropertyName("profile")]
        public Self Profile { get; set; }
    }
}
