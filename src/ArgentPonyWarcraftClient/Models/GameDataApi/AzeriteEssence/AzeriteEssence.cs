using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An azerite essence.
    /// </summary>
    public record AzeriteEssence
    {
        /// <summary>
        /// Gets links for the azerite essence.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the azerite essence.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets references to the allowed specializations for the azerite essence.
        /// </summary>
        [JsonPropertyName("allowed_specializations")]
        public PlayableSpecializationReference[] AllowedSpecializations { get; }

        /// <summary>
        /// Gets the powers for the azerite essence.
        /// </summary>
        [JsonPropertyName("powers")]
        public Power[] Powers { get; }

        /// <summary>
        /// Gets the media associated with the azerite essence.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzeriteEssence"/> class.
        /// </summary>
        /// <param name="links">Links for the azerite essence.</param>
        /// <param name="id">The ID of the azerite essence.</param>
        /// <param name="name">The name of the azerite essence.</param>
        /// <param name="allowedSpecializations">References to the allowed specializations for the azerite essence.</param>
        /// <param name="powers">The powers for the azerite essence.</param>
        /// <param name="media">The media associated with the azerite essence.</param>
        [JsonConstructor]
        public AzeriteEssence(Links links, int id, string name, PlayableSpecializationReference[] allowedSpecializations, Power[] powers, Media media)
        {
            Links = links;
            Id = id;
            Name = name;
            AllowedSpecializations = allowedSpecializations;
            Powers = powers;
            Media = media;
        }
    }
}
