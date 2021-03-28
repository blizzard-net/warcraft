using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Pet ability media.
    /// </summary>
    public record PetAbilityMedia
    {
        /// <summary>
        /// Gets links for the pet ability media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the pet ability.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetAbilityMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the pet ability media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the pet ability.</param>
        [JsonConstructor]
        public PetAbilityMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
