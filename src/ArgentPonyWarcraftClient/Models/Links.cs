using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A collection of links.
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Gets a self-reference.
        /// </summary>
        [JsonProperty("self")]
        public Self Self { get; private set; }
    }
}
