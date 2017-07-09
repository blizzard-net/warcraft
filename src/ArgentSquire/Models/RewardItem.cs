using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A reward item.
    /// </summary>
    public class RewardItem
    {
        /// <summary>
        /// Gets the appearance.
        /// </summary>
        [JsonProperty(PropertyName = "appearance")]
        public Appearance Appearance { get; private set; }

        /// <summary>
        /// Gets the armor.
        /// </summary>
        [JsonProperty(PropertyName = "armor")]
        public int Armor { get; private set; }

        /// <summary>
        /// Gets the artifact ID.
        /// </summary>
        [JsonProperty(PropertyName = "artifactId")]
        public int ArtifactId { get; private set; }

        /// <summary>
        /// Gets the artifact appearance ID.
        /// </summary>
        [JsonProperty(PropertyName = "artifactAppearanceId")]
        public int ArtifactAppearanceId { get; private set; }

        /// <summary>
        /// Gets the artifact traits.
        /// </summary>
        [JsonProperty(PropertyName = "artifactTraits")]
        public List<object> ArtifactTraits { get; private set; }

        /// <summary>
        /// Gets the bonus lists.
        /// </summary>
        [JsonProperty(PropertyName = "bonusLists")]
        public List<object> BonusLists { get; private set; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; private set; }

        /// <summary>
        /// Gets the display info ID.
        /// </summary>
        [JsonProperty(PropertyName = "displayInfoId")]
        public int DisplayInfoId { get; private set; }

        /// <summary>
        /// Gets the name of the icon for the reward.
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; private set; }

        /// <summary>
        /// Gets the reward ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; private set; }

        /// <summary>
        /// Gets the item level.
        /// </summary>
        [JsonProperty(PropertyName = "itemLevel")]
        public int ItemLevel { get; private set; }

        /// <summary>
        /// Gets the reward name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the reward quality.
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public int Quality { get; private set; }

        /// <summary>
        /// Gets the relics.
        /// </summary>
        [JsonProperty(PropertyName = "relics")]
        public List<object> Relics { get; private set; }

        /// <summary>
        /// Gets the stats.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public List<object> Stats { get; private set; }

        /// <summary>
        /// Gets the tooltip parameters.
        /// </summary>
        [JsonProperty(PropertyName = "tooltipParams")]
        public TooltipParams TooltipParams { get; private set; }
    }
}
