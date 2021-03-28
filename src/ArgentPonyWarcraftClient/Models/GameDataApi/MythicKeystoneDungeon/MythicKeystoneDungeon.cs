using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone dungeon.
    /// </summary>
    public record MythicKeystoneDungeon
    {
        /// <summary>
        /// Gets links for the mythic keystone dungeon.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the mythic keystone dungeon.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets the name of the mythic keystone dungeon.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets the map of the mythic keystone dungeon.
        /// </summary>
        [JsonPropertyName("map")]
        public Map Map { get; }

        /// <summary>
        /// Gets the zone for the mythic keystone dungeon.
        /// </summary>
        [JsonPropertyName("zone")]
        public ZoneReferenceSlug Zone { get; }

        /// <summary>
        /// Gets a reference to the dungeon instance.
        /// </summary>
        [JsonPropertyName("dungeon")]
        public InstanceReference Dungeon { get; }

        /// <summary>
        /// Gets the keystone upgrades for the mythic keystone dungeon.
        /// </summary>
        [JsonPropertyName("keystone_upgrades")]
        public MythicKeystoneUpgrade[] KeystoneUpgrades { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MythicKeystoneDungeon"/> class.
        /// </summary>
        /// <param name="links">Links for the mythic keystone dungeon.</param>
        /// <param name="id">The ID of the mythic keystone dungeon.</param>
        /// <param name="name">The name of the mythic keystone dungeon.</param>
        /// <param name="map">The map of the mythic keystone dungeon.</param>
        /// <param name="zone">The zone for the mythic keystone dungeon.</param>
        /// <param name="dungeon">A reference to the dungeon instance.</param>
        /// <param name="keystoneUpgrades">The keystone upgrades for the mythic keystone dungeon.</param>
        [JsonConstructor]
        public MythicKeystoneDungeon(Links links, int id, string name, Map map, ZoneReferenceSlug zone, InstanceReference dungeon, MythicKeystoneUpgrade[] keystoneUpgrades)
        {
            Links = links;
            Id = id;
            Name = name;
            Map = map;
            Zone = zone;
            Dungeon = dungeon;
            KeystoneUpgrades = keystoneUpgrades;
        }
    }
}
