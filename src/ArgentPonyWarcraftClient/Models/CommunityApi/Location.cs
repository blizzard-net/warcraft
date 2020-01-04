using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A location.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets the location ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }
    }
}
