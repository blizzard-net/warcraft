using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A connected realm.
    /// </summary>
    public record ConnectedRealm
    {
        /// <summary>
        /// Gets links for the connected realm.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; }

        /// <summary>
        /// Gets the ID of the connected realm.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether there is a queue to log in to the connected realm.
        /// </summary>
        [JsonPropertyName("has_queue")]
        public bool HasQueue { get; }

        /// <summary>
        /// Gets the status of the realm.
        /// </summary>
        [JsonPropertyName("status")]
        public EnumType Status { get; }

        /// <summary>
        /// Gets a rough indicator of the connected realm population.
        /// </summary>
        [JsonPropertyName("population")]
        public EnumType Population { get; }

        /// <summary>
        /// Gets the realms in the connected realm.
        /// </summary>
        [JsonPropertyName("realms")]
        public Realm[] Realms { get; }

        /// <summary>
        /// Gets a reference to the Mythic Keystone Leaderboard data for this connected realm.
        /// </summary>
        [JsonPropertyName("mythic_leaderboards")]
        public Self MythicLeaderboards { get; }

        /// <summary>
        /// Gets a reference to the auction house data for this connected realm.
        /// </summary>
        [JsonPropertyName("auctions")]
        public Self Auctions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedRealm"/> class.
        /// </summary>
        /// <param name="links">Links for the connected realm.</param>
        /// <param name="id">The ID of the connected realm.</param>
        /// <param name="hasQueue">A value indicating whether there is a queue to log in to the connected realm.</param>
        /// <param name="status">The status of the realm.</param>
        /// <param name="population">A rough indicator of the connected realm population.</param>
        /// <param name="realms">The realms in the connected realm.</param>
        /// <param name="mythicLeaderboards">A reference to the Mythic Keystone Leaderboard data for this connected realm.</param>
        /// <param name="auctions">A reference to the auction house data for this connected realm.</param>
        [JsonConstructor]
        public ConnectedRealm(Links links, int id, bool hasQueue, EnumType status, EnumType population, Realm[] realms, Self mythicLeaderboards, Self auctions)
        {
            Links = links;
            Id = id;
            HasQueue = hasQueue;
            Status = status;
            Population = population;
            Realms = realms;
            MythicLeaderboards = mythicLeaderboards;
            Auctions = auctions;
        }
    }
}
