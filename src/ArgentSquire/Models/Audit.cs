using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// Audit information for a character.
    /// </summary>
    public class Audit
    {
        /// <summary>
        /// Gets or sets the number of issues.
        /// </summary>
        [JsonProperty("numberOfIssues")]
        public int NumberOfIssues { get; set; }

        /// <summary>
        /// Gets or sets the slots.
        /// </summary>
        [JsonProperty("slots")]
        public IDictionary<int, int> Slots { get; set; }

        /// <summary>
        /// Gets or sets the empty glyph slots.
        /// </summary>
        [JsonProperty("emptyGlyphSlots")]
        public int EmptyGlyphSlots { get; set; }

        /// <summary>
        /// Gets or sets the unspent talent points.
        /// </summary>
        [JsonProperty("unspentTalentPoints")]
        public int UnspentTalentPoints { get; set; }

        /// <summary>
        /// Gets or sets an indicator of whether the character has no spec.
        /// </summary>
        [JsonProperty("noSpec")]
        public bool NoSpec { get; set; }

        /// <summary>
        /// Gets or sets the unenchanted items.
        /// </summary>
        [JsonProperty("unenchantedItems")]
        public IDictionary<int, int> UnenchantedItems { get; set; }

        /// <summary>
        /// Gets or sets the empty sockets.
        /// </summary>
        [JsonProperty("emptySockets")]
        public int EmptySockets { get; set; }

        /// <summary>
        /// Gets or sets the items with empty sockets.
        /// </summary>
        [JsonProperty("itemsWithEmptySockets")]
        public IDictionary<int, int> ItemsWithEmptySockets { get; set; }

        /// <summary>
        /// Gets or sets the appropriate armor type.
        /// </summary>
        [JsonProperty("appropriateArmorType")]
        public int AppropriateArmorType { get; set; }

        /// <summary>
        /// Gets or sets the inappropriate armor type settings.
        /// </summary>
        [JsonProperty("inappropriateArmorType")]
        public IDictionary<int, int> InappropriateArmorType { get; set; }

        /// <summary>
        /// Gets or sets the low level items.
        /// </summary>
        [JsonProperty("lowLevelItems")]
        public IDictionary<int, int> LowLevelItems { get; set; }

        /// <summary>
        /// Gets or sets the low level threshold.
        /// </summary>
        [JsonProperty("lowLevelThreshold")]
        public int LowLevelThreshold { get; set; }

        /// <summary>
        /// Gets or sets the missing extra sockets.
        /// </summary>
        [JsonProperty("missingExtraSockets")]
        public IDictionary<int, int> MissingExtraSockets { get; set; }

        /// <summary>
        /// Gets or sets the recommended belt buckle.
        /// </summary>
        [JsonProperty("recommendedBeltBuckle")]
        public Item RecommendedBeltBuckle { get; set; }

        /// <summary>
        /// Gets or sets the missing blacksmith sockets.
        /// </summary>
        [JsonProperty("missingBlacksmithSockets")]
        public IDictionary<int, int> MissingBlacksmithSockets { get; set; }

        /// <summary>
        /// Gets or sets the missing enchanter enchants.
        /// </summary>
        [JsonProperty("missingEnchanterEnchants")]
        public IDictionary<int, int> MissingEnchanterEnchants { get; set; }

        /// <summary>
        /// Gets or sets the missing engineer enchants.
        /// </summary>
        [JsonProperty("missingEngineerEnchants")]
        public IDictionary<int, int> MissingEngineerEnchants { get; set; }

        /// <summary>
        /// Gets or sets the missing scribe enchants.
        /// </summary>
        [JsonProperty("missingScribeEnchants")]
        public IDictionary<int, int> MissingScribeEnchants { get; set; }

        /// <summary>
        /// Gets or sets the missing jewelcrafter gems.
        /// </summary>
        [JsonProperty("nMissingJewelcrafterGems")]
        public int MissingJewelcrafterGems { get; set; }

        /// <summary>
        /// Gets or sets the missing leatherworker enchants.
        /// </summary>
        [JsonProperty("missingLeatherworkerEnchants")]
        public IDictionary<int, int> MissingLeatherworkerEnchants { get; set; }
    }
}
