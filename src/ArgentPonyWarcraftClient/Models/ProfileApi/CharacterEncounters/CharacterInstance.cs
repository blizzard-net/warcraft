using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An instance that a character has completed.
    /// </summary>
    public record CharacterInstance
    {
        /// <summary>
        /// Gets a reference to the instance.
        /// </summary>
        [JsonPropertyName("instance")]
        public InstanceReference Instance { get; }

        /// <summary>
        /// Gets the dungeon completions for the instance, organized by difficulty mode.
        /// </summary>
        [JsonPropertyName("modes")]
        public CharacterInstanceMode[] Modes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterInstance"/> class.
        /// </summary>
        /// <param name="instance">A reference to the instance.</param>
        /// <param name="modes">The dungeon completions for the instance, organized by difficulty mode.</param>
        [JsonConstructor]
        public CharacterInstance(InstanceReference instance, CharacterInstanceMode[] modes)
        {
            Instance = instance;
            Modes = modes;
        }
    }
}
