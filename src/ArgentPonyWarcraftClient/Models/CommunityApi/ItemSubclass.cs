using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// An item subclass.
    /// </summary>
    public class ItemSubclass
    {
        /// <summary>
        /// Gets or sets the item subclass ID.
        /// </summary>
        [JsonProperty("subclass")]
        public int Subclass { get; set; }

        /// <summary>
        /// Gets or sets the item subclass name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
