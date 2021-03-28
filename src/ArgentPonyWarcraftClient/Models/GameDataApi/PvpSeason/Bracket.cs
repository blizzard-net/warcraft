using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A PvP bracket.
    /// </summary>
    public record Bracket
    {
        /// <summary>
        /// Gets the ID of the PvP bracket.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the type of the PvP bracket.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bracket"/> class.
        /// </summary>
        /// <param name="id">The ID of the PvP bracket.</param>
        /// <param name="type">The type of the PvP bracket.</param>
        [JsonConstructor]
        public Bracket(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
