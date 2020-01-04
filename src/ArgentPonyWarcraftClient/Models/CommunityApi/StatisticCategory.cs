using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A statistics category.
    /// </summary>
    public class StatisticCategory
    {
        /// <summary>
        /// Gets or sets the subcategory ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the subcategory name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the statistics in the subcategory.
        /// </summary>
        [JsonProperty("statistics")]
        public IList<Statistic> Statistics { get; set; }

        /// <summary>
        /// Gets or sets subcategories of this subcategory.
        /// </summary>
        [JsonProperty("subCategories")]
        public IList<StatisticCategory> SubCategories { get; set; }
    }
}
