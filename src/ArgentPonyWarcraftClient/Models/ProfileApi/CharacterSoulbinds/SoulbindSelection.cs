using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary> 
    /// A soulbind selection for a character.
    /// </summary>
    public record SoulbindSelection
    {
        /// <summary>
        /// Gets a reference to the soulbind.
        /// </summary>
        [JsonPropertyName("soulbind")]
        public SoulbindReference Soulbind { get; }

        /// <summary>
        /// Gets the soulbinds and associated traits for the character.
        /// </summary>
        [JsonPropertyName("traits")]
        public SoulbindTrait[] Traits { get; }

        /// <summary>
        /// Gets a value indicating whether the soulbind is active for this character.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool IsActive { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoulbindSelection"/> class.
        /// </summary>
        /// <param name="soulbind">A reference to the soulbind.</param>
        /// <param name="traits">The soulbinds and associated traits for the character.</param>
        /// <param name="isActive">A value indicating whether the soulbind is active for this character.</param>
        [JsonConstructor]
        public SoulbindSelection(SoulbindReference soulbind, SoulbindTrait[] traits, bool isActive)
        {
            Soulbind = soulbind;
            Traits = traits;
            IsActive = isActive;
        }
    }
}
