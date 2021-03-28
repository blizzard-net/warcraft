using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Creature display media.
    /// </summary>
    public record CreatureDisplayMedia
    {
        /// <summary>
        /// Gets links for the creature display media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the creature display.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatureDisplayMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the creature display media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the creature display.</param>
        [JsonConstructor]
        public CreatureDisplayMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
