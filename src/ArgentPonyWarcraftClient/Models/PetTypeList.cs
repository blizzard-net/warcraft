using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A list of pet types.
    /// </summary>
    public class PetTypeList
    {
        /// <summary>
        /// Gets or sets the pet types.
        /// </summary>
        [JsonProperty("petTypes")]
        public IList<PetType> PetTypes { get; set; }
    }
}
