using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A zone.
    /// </summary>
    public class Zone
    {
        /// <summary>
        /// Gets or sets the zone ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the zone name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URL slug.
        /// </summary>
        [JsonProperty("urlSlug")]
        public string UrlSlug { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the expansion ID.
        /// </summary>
        [JsonProperty("expansionId")]
        public int ExpansionId { get; set; }

        /// <summary>
        /// Gets or sets the patch.
        /// </summary>
        [JsonProperty("patch")]
        public string Patch { get; set; }

        /// <summary>
        /// Gets or sets the number of players.
        /// </summary>
        [JsonProperty("numPlayers")]
        public string NumPlayers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the zone is a dungeon.
        /// </summary>
        [JsonProperty("isDungeon")]
        public bool IsDungeon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the zone is a raid.
        /// </summary>
        [JsonProperty("isRaid")]
        public bool IsRaid { get; set; }

        /// <summary>
        /// Gets or sets the advised minimum level.
        /// </summary>
        [JsonProperty("advisedMinLevel")]
        public int AdvisedMinLevel { get; set; }

        /// <summary>
        /// Gets or sets the advised maximum level.
        /// </summary>
        [JsonProperty("advisedMaxLevel")]
        public int AdvisedMaxLevel { get; set; }

        /// <summary>
        /// Gets or sets the advised heroic minimum level.
        /// </summary>
        [JsonProperty("advisedHeroicMinLevel")]
        public int AdvisedHeroicMinLevel { get; set; }

        /// <summary>
        /// Gets or sets the advised heroic maximum level.
        /// </summary>
        [JsonProperty("advisedHeroicMaxLevel")]
        public int AdvisedHeroicMaxLevel { get; set; }

        /// <summary>
        /// Gets or sets the available modes.
        /// </summary>
        [JsonProperty("availableModes")]
        public IList<string> AvailableModes { get; set; }

        /// <summary>
        /// Gets or sets Looking for Group Normal mode minimum gear level.
        /// </summary>
        [JsonProperty("lfgNormalMinGearLevel")]
        public int LfgNormalMinGearLevel { get; set; }

        /// <summary>
        /// Gets or sets Looking for Group Heroic mode minimum gear level.
        /// </summary>
        [JsonProperty("lfgHeroicMinGearLevel")]
        public int LfgHeroicMinGearLevel { get; set; }

        /// <summary>
        /// Gets or sets the number of floors.
        /// </summary>
        [JsonProperty("floors")]
        public int Floors { get; set; }

        /// <summary>
        /// Gets or sets the bosses.
        /// </summary>
        [JsonProperty("bosses")]
        public IList<Boss> Bosses { get; set; }
    }
}
