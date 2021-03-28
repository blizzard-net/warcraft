using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mount belonging to a World of Warcraft account.
    /// </summary>
    public record AccountMount
    {
        /// <summary>
        /// Gets a reference to the mount.
        /// </summary>
        [JsonPropertyName("mount")]
        public MountReference Mount { get; }

        /// <summary>
        /// Gets a value indicating whether the mount is a favorite.
        /// </summary>
        [JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountMount"/> class.
        /// </summary>
        /// <param name="mount">A reference to the mount.</param>
        /// <param name="isFavorite">A value indicating whether the mount is a favorite.</param>
        [JsonConstructor]
        public AccountMount(MountReference mount, bool? isFavorite)
        {
            Mount = mount;
            IsFavorite = isFavorite;
        }
    }
}
