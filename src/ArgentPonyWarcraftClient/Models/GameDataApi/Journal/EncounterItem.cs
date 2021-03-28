using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item that can appear as loot from an encounter.
    /// </summary>
    public record EncounterItem
    {
        /// <summary>
        /// Gets the ID of the encounter item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a reference to the item.
        /// </summary>
        [JsonPropertyName("item")]
        public ItemReference Item { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncounterItem"/> class.
        /// </summary>
        /// <param name="id">The ID of the encounter item.</param>
        /// <param name="item">A reference to the item.</param>
        [JsonConstructor]
        public EncounterItem(int id, ItemReference item)
        {
            Id = id;
            Item = item;
        }
    }
}
