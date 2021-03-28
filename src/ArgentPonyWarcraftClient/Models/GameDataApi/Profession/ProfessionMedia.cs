using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Profession media.
    /// </summary>
    public record ProfessionMedia
    {
        /// <summary>
        /// Gets links for the profession media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the profession.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfessionMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the profession media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the profession.</param>
        [JsonConstructor]
        public ProfessionMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
