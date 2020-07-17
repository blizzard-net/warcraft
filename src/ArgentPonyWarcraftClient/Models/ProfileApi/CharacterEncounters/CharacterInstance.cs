using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An instance that a character has completed.
    /// </summary>
    public class CharacterInstance
    {
        /// <summary>
        /// Gets a reference to the instance.
        /// </summary>
        [JsonPropertyName("instance")]
        public InstanceReference Instance { get; set; }

        /// <summary>
        /// Gets the dungeon completions for the instance, organized by difficulty mode.
        /// </summary>
        [JsonPropertyName("modes")]
        public CharacterInstanceMode[] Modes { get; set; }
    }
}
