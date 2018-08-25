using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character equipment item.
    /// </summary>
    public class CharacterItem
    {
        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the item name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the icon for the item.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the item quality.
        /// </summary>
        [JsonProperty("quality")]
        public ItemQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the item level.
        /// </summary>
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }

        /// <summary>
        /// Gets or sets the tooltip parameters.
        /// </summary>
        [JsonProperty("tooltipParams")]
        public TooltipParams TooltipParams { get; set; }

        /// <summary>
        /// Gets or sets the item stats.
        /// </summary>
        [JsonProperty("stats")]
        public IList<Stat> Stats { get; set; }

        /// <summary>
        /// Gets or sets the item's armor points.
        /// </summary>
        [JsonProperty("armor")]
        public int Armor { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the bonus lists.
        /// </summary>
        [JsonProperty("bonusLists")]
        public IList<int> BonusLists { get; set; }

        /// <summary>
        /// Gets or sets the artifact ID.
        /// </summary>
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }

        /// <summary>
        /// Gets or sets the display info ID.
        /// </summary>
        [JsonProperty("displayInfoId")]
        public int DisplayInfoId { get; set; }

        /// <summary>
        /// Gets or sets the artifact appearance ID.
        /// </summary>
        [JsonProperty("artifactAppearanceId")]
        public int ArtifactAppearanceId { get; set; }

        /// <summary>
        /// Gets or sets the artifact traits.
        /// </summary>
        [JsonProperty("artifactTraits")]
        public IList<ArtifactTrait> ArtifactTraits { get; set; }

        /// <summary>
        /// Gets or sets the relics.
        /// </summary>
        [JsonProperty("relics")]
        public IList<Relic> Relics { get; set; }

        /// <summary>
        /// Gets or sets the appearance.
        /// </summary>
        [JsonProperty("appearance")]
        public Appearance Appearance { get; set; }

        /// <summary>
        /// Gets or sets the Azerite item.
        /// </summary>
        [JsonProperty("azeriteItem")]
        public AzeriteItem AzeriteItem { get; set; }

        /// <summary>
        /// Gets or sets the weapon info.
        /// </summary>
        [JsonProperty("weaponInfo")]
        public WeaponInfo WeaponInfo { get; set; }
    }
}
