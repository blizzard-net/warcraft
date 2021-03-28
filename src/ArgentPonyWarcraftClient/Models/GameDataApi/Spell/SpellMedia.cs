using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Spell media.
    /// </summary>
    public record SpellMedia
    {
        /// <summary>
        /// Gets links for the spell media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the spell.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpellMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the spell media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the spell.</param>
        [JsonConstructor]
        public SpellMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
