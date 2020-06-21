using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone dungeon.
    /// </summary>
    public class MythicKeystoneDungeon
    {
        /// <summary>
        /// Gets links for the mythic keystone dungeon.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mythic keystone dungeon.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the mythic keystone dungeon.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the map of the mythic keystone dungeon.
        /// </summary>
        [JsonProperty("map")]
        public Map Map { get; set; }

        /// <summary>
        /// Gets the zone for the mythic keystone dungeon.
        /// </summary>
        [JsonProperty("zone")]
        public ZoneReferenceSlug Zone { get; set; }

        /// <summary>
        /// Gets a reference to the dungeon instance.
        /// </summary>
        [JsonProperty("dungeon")]
        public InstanceReference Dungeon { get; set; }

        /// <summary>
        /// Gets the keystone upgrades for the mythic keystone dungeon.
        /// </summary>
        [JsonProperty("keystone_upgrades")]
        public MythicKeystoneUpgrade[] KeystoneUpgrades { get; set; }
    }
}
