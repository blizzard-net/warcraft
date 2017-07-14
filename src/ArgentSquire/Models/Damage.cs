using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// Damage.
    /// </summary>
    public class Damage
    {
        /// <summary>
        /// Gets or sets the minimum damage.
        /// </summary>
        [JsonProperty("min")]
        public int Min { get; set; }

        /// <summary>
        /// Gets or sets the maximum damage.
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }

        /// <summary>
        /// Gets or sets the exact minimum damage.
        /// </summary>
        [JsonProperty("exactMin")]
        public double ExactMin { get; set; }

        /// <summary>
        /// Gets or sets the exact maximum damage.
        /// </summary>
        [JsonProperty("exactMax")]
        public double ExactMax { get; set; }
    }
}
