using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// An achievement criterion.
    /// </summary>
    public class Criterion
    {
        /// <summary>
        /// Gets the criterion description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the criterion ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the max number.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public int Max { get; private set; }

        /// <summary>
        /// Gets the order index.
        /// </summary>
        [JsonProperty(PropertyName = "orderIndex")]
        public int OrderIndex { get; private set; }
    }
}
