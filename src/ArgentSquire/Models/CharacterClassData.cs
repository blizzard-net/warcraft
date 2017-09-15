using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// Character class data.
    /// </summary>
    public class CharacterClassData
    {
        /// <summary>
        /// Gets or sets the character class ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the mask.
        /// </summary>
        [JsonProperty("mask")]
        public int Mask { get; set; }

        /// <summary>
        /// Gets or sets the power type.
        /// </summary>
        [JsonProperty("powerType")]
        public string PowerType { get; set; }

        /// <summary>
        /// Gets or sets the character class name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
