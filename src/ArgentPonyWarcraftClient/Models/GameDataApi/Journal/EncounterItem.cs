using ArgentPonyWarcraftClient.GameData;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// An item that can appear as loot from an encounter.
    /// </summary>
    public class EncounterItem
    {
        /// <summary>
        /// Gets the ID of the encounter item.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonProperty("item")]
        public ItemReference Item { get; set; }
    }
}
