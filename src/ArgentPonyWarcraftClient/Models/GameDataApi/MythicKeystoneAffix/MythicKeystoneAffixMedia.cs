using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Mythic keystone affix media.
    /// </summary>
    public record MythicKeystoneAffixMedia
    {
        /// <summary>
        /// Gets links for the mythic keystone affix media.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets a collection of media assets.
        /// </summary>
        [JsonPropertyName("assets")]
        public Asset[] Assets { get; }

        /// <summary>
        /// Gets the ID of the mythic keystone affix.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneAffixMedia"/> class.
        /// </summary>
        /// <param name="links">Links for the mythic keystone affix media.</param>
        /// <param name="assets">A collection of media assets.</param>
        /// <param name="id">The ID of the mythic keystone affix.</param>
        [JsonConstructor]
        public MythicKeystoneAffixMedia(Links links, Asset[] assets, int id)
        {
            Links = links;
            Assets = assets;
            Id = id;
        }
    }
}
