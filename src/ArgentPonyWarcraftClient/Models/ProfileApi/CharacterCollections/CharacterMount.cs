using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A specific mount that has been collected by a character.
    /// </summary>
    public class CharacterMount
    {
        /// <summary>
        /// Gets a reference to the type of mount.
        /// </summary>
        [JsonProperty("mount")]
        public MountReference Mount { get; set; }

        /// <summary>
        /// Gets a value indicating whether this mount is a favorite for the character.
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }
    }
}
