using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of power types.
    /// </summary>
    public record PowerTypesIndex
    {
        /// <summary>
        /// Gets links for the index of power types.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets references to the power types.
        /// </summary>
        [JsonPropertyName("power_types")]
        public PowerTypeReference[] PowerTypes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerTypesIndex"/> class.
        /// </summary>
        /// <param name="links">Links for the index of power types.</param>
        /// <param name="powerTypes">References to the power types.</param>
        [JsonConstructor]
        public PowerTypesIndex(Links links, PowerTypeReference[] powerTypes)
        {
            Links = links;
            PowerTypes = powerTypes;
        }
    }
}
