using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character achievement statistic category.
    /// </summary>
    public record Category
    {
        /// <summary>
        /// Gets the ID of the category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the subcategories of the category, if any.
        /// </summary>
        [JsonPropertyName("sub_categories")]
        public Category[] SubCategories { get; }

        /// <summary>
        /// Gets the character achievement statistics in the category.
        /// </summary>
        [JsonPropertyName("statistics")]
        public Statistic[] Statistics { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="id">The ID of the category.</param>
        /// <param name="name">The name of the category.</param>
        /// <param name="subCategories">The subcategories of the category, if any.</param>
        /// <param name="statistics">The character achievement statistics in the category.</param>
        [JsonConstructor]
        public Category(int id, string name, Category[] subCategories, Statistic[] statistics)
        {
            Id = id;
            Name = name;
            SubCategories = subCategories;
            Statistics = statistics;
        }
    }
}
