using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A title for a character.
    /// </summary>
    public record Title
    {
        /// <summary>
        /// Gets links for the title.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the title.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the title.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the gender-specific names for the title.
        /// </summary>
        [JsonPropertyName("gender_name")]
        public GenderName GenderName { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Title"/> class.
        /// </summary>
        /// <param name="links">Links for the title.</param>
        /// <param name="id">The ID of the title.</param>
        /// <param name="name">The name of the title.</param>
        /// <param name="genderName">The gender-specific names for the title.</param>
        [JsonConstructor]
        public Title(Links links, int id, string name, GenderName genderName)
        {
            Links = links;
            Id = id;
            Name = name;
            GenderName = genderName;
        }
    }
}
