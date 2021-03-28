using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a pet.
    /// </summary>
    public record PetReference
    {
        /// <summary>
        /// Gets the key for the pet.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; }

        /// <summary>
        /// Gets the name of the pet.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the ID of the pet.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetReference"/> class.
        /// </summary>
        /// <param name="key">The key for the pet.</param>
        /// <param name="name">The name of the pet.</param>
        /// <param name="id">The ID of the pet.</param>
        [JsonConstructor]
        public PetReference(Self key, string name, int id)
        {
            Key = key;
            Name = name;
            Id = id;
        }
    }
}
