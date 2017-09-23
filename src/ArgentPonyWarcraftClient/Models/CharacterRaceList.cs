using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of character races.
    /// </summary>
    public class CharacterRaceList
    {
        /// <summary>
        /// Gets or sets the races.
        /// </summary>
        [JsonProperty("races")]
        public IList<CharacterRace> Races { get; set; }
    }
}
