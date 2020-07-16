using Newtonsoft.Json;

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
        [JsonProperty("self")]
        public Self Self { get; set; }

        /// <summary>
        /// Gets a link to the user.
        /// </summary>
        [JsonProperty("user")]
        public Self User { get; set; }

        /// <summary>
        /// Gets a link to the profile.
        /// </summary>
        [JsonProperty("profile")]
        public Self Profile { get; set; }
    }
}
