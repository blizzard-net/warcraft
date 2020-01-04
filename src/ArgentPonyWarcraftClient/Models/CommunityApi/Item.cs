using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// An item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the disenchanting skill rank required to disenchant the item.
        /// </summary>
        [JsonProperty("disenchantingSkillRank")]
        public int DisenchantingSkillRank { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the stackable setting.
        /// </summary>
        [JsonProperty("stackable")]
        public int Stackable { get; set; }

        /// <summary>
        /// Gets or sets the item bind setting.
        /// </summary>
        [JsonProperty("itemBind")]
        public int ItemBind { get; set; }

        /// <summary>
        /// Gets or sets the bonus stats.
        /// </summary>
        [JsonProperty("bonusStats")]
        public IList<Stat> BonusStats { get; set; }

        /// <summary>
        /// Gets or sets the item spells.
        /// </summary>
        [JsonProperty("itemSpells")]
        public IList<ItemSpell> ItemSpells { get; set; }

        /// <summary>
        /// Gets or sets the buy price.
        /// </summary>
        [JsonProperty("buyPrice")]
        public int BuyPrice { get; set; }

        /// <summary>
        /// Gets or sets the item class.
        /// </summary>
        [JsonProperty("itemClass")]
        public int ItemClass { get; set; }

        /// <summary>
        /// Gets or sets the item subclass.
        /// </summary>
        [JsonProperty("itemSubClass")]
        public int ItemSubClass { get; set; }

        /// <summary>
        /// Gets or sets the container slots.
        /// </summary>
        [JsonProperty("containerSlots")]
        public int ContainerSlots { get; set; }

        /// <summary>
        /// Gets or sets the weapon info.
        /// </summary>
        [JsonProperty("weaponInfo")]
        public WeaponInfo WeaponInfo { get; set; }

        /// <summary>
        /// Gets or sets the inventory type.
        /// </summary>
        [JsonProperty("inventoryType")]
        public int InventoryType { get; set; }

        /// <summary>
        /// Gets or sets an indicator of whether the item is equippable.
        /// </summary>
        [JsonProperty("equippable")]
        public bool Equippable { get; set; }

        /// <summary>
        /// Gets or sets the item level.
        /// </summary>
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }

        /// <summary>
        /// Gets or sets the maximum count.
        /// </summary>
        [JsonProperty("maxCount")]
        public int MaxCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum durability.
        /// </summary>
        [JsonProperty("maxDurability")]
        public int MaxDurability { get; set; }

        /// <summary>
        /// Gets or sets the faction ID for the minimum reputation setting.
        /// </summary>
        [JsonProperty("minFactionId")]
        public int MinFactionId { get; set; }

        /// <summary>
        /// Gets or sets the minimum reputation required to acquire the item.
        /// </summary>
        [JsonProperty("minReputation")]
        public int MinReputation { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        [JsonProperty("quality")]
        public ItemQuality Quality { get; set; }

        /// <summary>
        /// Gets or sets the sell price.
        /// </summary>
        [JsonProperty("sellPrice")]
        public int SellPrice { get; set; }

        /// <summary>
        /// Gets or sets the required skill.
        /// </summary>
        [JsonProperty("requiredSkill")]
        public int RequiredSkill { get; set; }

        /// <summary>
        /// Gets or sets the required level.
        /// </summary>
        [JsonProperty("requiredLevel")]
        public int RequiredLevel { get; set; }

        /// <summary>
        /// Gets or sets the required skill rank.
        /// </summary>
        [JsonProperty("requiredSkillRank")]
        public int RequiredSkillRank { get; set; }

        /// <summary>
        /// Gets or sets the item source.
        /// </summary>
        [JsonProperty("itemSource")]
        public ItemSource ItemSource { get; set; }

        /// <summary>
        /// Gets or sets the base armor.
        /// </summary>
        [JsonProperty("baseArmor")]
        public int BaseArmor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item has sockets.
        /// </summary>
        [JsonProperty("hasSockets")]
        public bool HasSockets { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is auctionable.
        /// </summary>
        [JsonProperty("isAuctionable")]
        public bool IsAuctionable { get; set; }

        /// <summary>
        /// Gets or sets the armor value.
        /// </summary>
        [JsonProperty("armor")]
        public int Armor { get; set; }

        /// <summary>
        /// Gets or sets the display info ID.
        /// </summary>
        [JsonProperty("displayInfoId")]
        public int DisplayInfoId { get; set; }

        /// <summary>
        /// Gets or sets the name description.
        /// </summary>
        [JsonProperty("nameDescription")]
        public string NameDescription { get; set; }

        /// <summary>
        /// Gets or sets the name description color.
        /// </summary>
        [JsonProperty("nameDescriptionColor")]
        public string NameDescriptionColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is upgradeable.
        /// </summary>
        [JsonProperty("upgradable")]
        public bool Upgradable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item has a heroic tooltip.
        /// </summary>
        [JsonProperty("heroicTooltip")]
        public bool HeroicTooltip { get; set; }

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
        /// Gets or sets the available contexts.
        /// </summary>
        [JsonProperty("availableContexts")]
        public IList<string> AvailableContexts { get; set; }

        /// <summary>
        /// Gets or sets the bonus summary.
        /// </summary>
        [JsonProperty("bonusSummary")]
        public BonusSummary BonusSummary { get; set; }

        /// <summary>
        /// Gets or sets the artifact ID.
        /// </summary>
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }
    }
}
