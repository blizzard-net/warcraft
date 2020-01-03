using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An item set.
    /// </summary>
    public class ItemSet
    {
        /// <summary>
        /// Gets or sets the item set ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the item set name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the set bonuses.
        /// </summary>
        [JsonProperty("setBonuses")]
        public IList<SetBonus> SetBonuses { get; set; }

        /// <summary>
        /// Gets or sets the IDs of the items that belong to the set.
        /// </summary>
        [JsonProperty("items")]
        public IList<int> Items { get; set; }
    }
}
