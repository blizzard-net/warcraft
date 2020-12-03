using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a renown reward.
    /// </summary>
    public class RenownRewardReference
    {
        /// <summary>
        /// Gets the key for the renown reward reference.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name for the renown reward reference.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the Id for the renown reward reference.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
