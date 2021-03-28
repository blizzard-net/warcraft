using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A battle pet type.
    /// </summary>
    public record BattlePetType
    {
        /// <summary>
        /// Gets the ID of the battle pet type.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the type of the battle pet type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// Gets the name of the battle pet type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BattlePetType"/> class.
        /// </summary>
        /// <param name="id">The ID of the battle pet type.</param>
        /// <param name="type">The type of the battle pet type.</param>
        /// <param name="name">The name of the battle pet type.</param>
        [JsonConstructor]
        public BattlePetType(int id, string type, string name)
        {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}
