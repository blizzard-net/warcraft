using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Profession media.
    /// </summary>
    public class ProfessionMedia
    {
        /// <summary>
        /// Gets links for the profession media.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; private set; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonProperty("assets")]
        public Asset[] Assets { get; private set; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
