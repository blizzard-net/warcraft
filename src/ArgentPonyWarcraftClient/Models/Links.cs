using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A collection of links.
    /// </summary>
    public record Links
    {
        /// <summary>
        /// Gets a self-reference.
        /// </summary>
        [JsonPropertyName("self")]
        public Self Self { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Links"/> class.
        /// </summary>
        /// <param name="self">A self-reference.</param>
        [JsonConstructor]
        public Links(Self self)
        {
            Self = self;
        }
    }
}
