using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mount belonging to a World of Warcraft account.
    /// </summary>
    public class AccountMount
    {
        /// <summary>
        /// Gets a reference to the mount.
        /// </summary>
        [JsonProperty("mount")]
        public MountReference Mount { get; set; }

        /// <summary>
        /// Gets a value indicating whether the mount is a favorite.
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }
    }
}
