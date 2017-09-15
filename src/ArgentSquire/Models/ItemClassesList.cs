using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A list of item classes.
    /// </summary>
    public class ItemClassesList
    {
        /// <summary>
        /// Gets or sets the item classes.
        /// </summary>
        [JsonProperty("classes")]
        public IList<ItemClass> Classes { get; set; }
    }
}
