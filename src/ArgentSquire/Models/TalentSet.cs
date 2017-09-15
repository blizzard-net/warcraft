using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A set of talents for a class.
    /// </summary>
    public class TalentSet
    {
        /// <summary>
        /// Gets or sets the class specs.
        /// </summary>
        [JsonProperty("specs")]
        public IList<Spec> Specs { get; set; }

        /// <summary>
        /// Gets or sets the pet specs.
        /// </summary>
        [JsonProperty("petSpecs")]
        public IList<Spec> PetSpecs { get; set; }

        /// <summary>
        /// Gets or sets the class talents.
        /// </summary>
        [JsonProperty("talents")]
        public IList<IList<IList<Talent>>> Talents { get; set; }

        /// <summary>
        /// Gets or sets the class name.
        /// </summary>
        [JsonProperty("class")]
        public string Class { get; set; }
    }
}
