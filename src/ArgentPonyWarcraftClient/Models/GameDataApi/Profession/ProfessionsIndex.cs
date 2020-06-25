using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of professions.
    /// </summary>
    public class ProfessionsIndex
    {
        /// <summary>
        /// Gets links for the index of professions.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the professions.
        /// </summary>
        [JsonProperty("professions")]
        public ProfessionReference[] Professions { get; set; }
    }
}
