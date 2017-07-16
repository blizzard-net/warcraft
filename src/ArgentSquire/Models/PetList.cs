using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A pet list.
    /// </summary>
    public class PetList
    {
        /// <summary>
        /// Gets or sets the list of pets.
        /// </summary>
        [JsonProperty("pets")]
        public IList<Pet> Pets { get; set; }
    }
}
