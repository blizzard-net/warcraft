using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A specific mount that has been collected by a character.
    /// </summary>
    public record CharacterMount
    {
        /// <summary>
        /// Gets a reference to the type of mount.
        /// </summary>
        [JsonPropertyName("mount")]
        public MountReference Mount { get; }

        /// <summary>
        /// Gets a value indicating whether this mount is a favorite for the character.
        /// </summary>
        [JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMount"/> class.
        /// </summary>
        /// <param name="mount">A reference to the type of mount.</param>
        /// <param name="isFavorite">A value indicating whether this mount is a favorite for the character.</param>
        [JsonConstructor]
        public CharacterMount(MountReference mount, bool? isFavorite)
        {
            Mount = mount;
            IsFavorite = isFavorite;
        }
    }
}
