using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character achievement statistic category.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets the ID of the category.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the category.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the subcategories of the category, if any.
        /// </summary>
        [JsonProperty("sub_categories", NullValueHandling = NullValueHandling.Ignore)]
        public Category[] SubCategories { get; set; }

        /// <summary>
        /// Gets the character achievement statistics in the category.
        /// </summary>
        [JsonProperty("statistics")]
        public Statistic[] Statistics { get; set; }
    }
}
