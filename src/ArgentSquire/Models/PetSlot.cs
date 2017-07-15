using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A pet slot.
    /// </summary>
    public class PetSlot
    {
        /// <summary>
        /// Gets or sets the slot number.
        /// </summary>
        [JsonProperty("slot")]
        public int Slot { get; set; }

        /// <summary>
        /// Gets or sets the battle pet GUID.
        /// </summary>
        [JsonProperty("battlePetGuid")]
        public string BattlePetGuid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the slot is empty.
        /// </summary>
        [JsonProperty("isEmpty")]
        public bool IsEmpty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the slot is locked.
        /// </summary>
        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Gets or sets the pet ability IDs.
        /// </summary>
        [JsonProperty("abilities")]
        public IList<int> Abilities { get; set; }
    }
}
