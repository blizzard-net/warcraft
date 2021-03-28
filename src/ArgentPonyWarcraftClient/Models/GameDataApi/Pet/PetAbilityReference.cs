using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a pet ability.
    /// </summary>
    public record PetAbilityReference
    {
        /// <summary>
        /// Gets the key for the pet ability.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the pet ability.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetAbilityReference"/> class.
        /// </summary>
        /// <param name="key">The key for the pet ability.</param>
        /// <param name="name">The name of the pet ability.</param>
        /// <param name="id">The ID of the pet ability.</param>
        [JsonConstructor]
        public PetAbilityReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
