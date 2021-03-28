using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Creature family media.
    /// </summary>
    public record CreatureFamilyMedia
    {
        /// <summary>
        /// Gets links for the creature family media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the creature family.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureFamilyMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the creature family media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the creature family.</param>
        [JsonConstructor]
        public CreatureFamilyMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
