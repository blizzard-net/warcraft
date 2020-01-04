using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A pet type.
    /// </summary>
    public class PetType
    {
        /// <summary>
        /// Gets or sets the pet type ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the pet type key.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the pet type name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type ability ID.
        /// </summary>
        [JsonProperty("typeAbilityId")]
        public int TypeAbilityId { get; set; }

        /// <summary>
        /// Gets or sets the strong against ID.
        /// </summary>
        [JsonProperty("strongAgainstId")]
        public int StrongAgainstId { get; set; }

        /// <summary>
        /// Gets or sets the weak against ID.
        /// </summary>
        [JsonProperty("weakAgainstId")]
        public int WeakAgainstId { get; set; }
    }
}
