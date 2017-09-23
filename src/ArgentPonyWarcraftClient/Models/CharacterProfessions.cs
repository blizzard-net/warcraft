using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Information about a character's professions.
    /// </summary>
    public class CharacterProfessions
    {
        /// <summary>
        /// The primary professions.
        /// </summary>
        [JsonProperty("primary")]
        public IList<Profession> Primary { get; set; }

        /// <summary>
        /// The secondary professions.
        /// </summary>
        [JsonProperty("secondary")]
        public IList<Profession> Secondary { get; set; }
    }
}
