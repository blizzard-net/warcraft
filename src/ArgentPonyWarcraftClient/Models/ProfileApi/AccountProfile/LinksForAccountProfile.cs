using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Links associated with a user profile.
    /// </summary>
    public record LinksForAccountProfile
    {
        /// <summary>
        /// Gets a self-reference.
        /// </summary>
        [JsonPropertyName("self")]
        public Self Self { get; }

        /// <summary>
        /// Gets a link to the user.
        /// </summary>
        [JsonPropertyName("user")]
        public Self User { get; }

        /// <summary>
        /// Gets a link to the profile.
        /// </summary>
        [JsonPropertyName("profile")]
        public Self Profile { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinksForAccountProfile"/> class.
        /// </summary>
        /// <param name="self">A self-reference.</param>
        /// <param name="user">A link to the user.</param>
        /// <param name="profile">A link to the profile.</param>
        [JsonConstructor]
        public LinksForAccountProfile(Self self, Self user, Self profile)
        {
            Self = self;
            User = user;
            Profile = profile;
        }
    }
}
