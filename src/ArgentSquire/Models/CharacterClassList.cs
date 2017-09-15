using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A character class list.
    /// </summary>
    public class CharacterClassList
    {
        /// <summary>
        /// Gets or sets the character classes.
        /// </summary>
        [JsonProperty("classes")]
        public IList<CharacterClassData> Classes { get; set; }
    }
}
