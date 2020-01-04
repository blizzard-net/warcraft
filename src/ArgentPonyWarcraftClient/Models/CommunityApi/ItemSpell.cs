using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// An item spell.
    /// </summary>
    public class ItemSpell
    {
        /// <summary>
        /// Get or sets the spell ID.
        /// </summary>
        [JsonProperty("spellId")]
        public int SpellId { get; set; }

        /// <summary>
        /// Get or sets the spell.
        /// </summary>
        [JsonProperty("spell")]
        public Spell Spell { get; set; }

        /// <summary>
        /// Get or sets the number of charges.
        /// </summary>
        [JsonProperty("nCharges")]
        public int Charges { get; set; }

        /// <summary>
        /// Get or sets a value indicating whether the item is consumable.
        /// </summary>
        [JsonProperty("consumable")]
        public bool Consumable { get; set; }

        /// <summary>
        /// Get or sets the category ID.
        /// </summary>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Get or sets the trigger.
        /// </summary>
        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        /// <summary>
        /// Get or sets the scaled description.
        /// </summary>
        [JsonProperty("scaledDescription")]
        public string ScaledDescription { get; set; }
    }
}
