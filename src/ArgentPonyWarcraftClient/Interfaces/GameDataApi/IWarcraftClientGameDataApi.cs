namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Game Data APIs.
    /// </summary>
    public interface IWarcraftClientGameDataApi :
        IWarcraftClientAchievementApi,
        IWarcraftClientAuctionHouseApi,
        IWarcraftClientConnectedRealmApi,
        IWarcraftClientCreatureApi,
        IWarcraftClientItemApi,
        IWarcraftClientJournalApi,
        IWarcraftClientMountApi,
        IWarcraftClientMythicKeystoneLeaderboardApi,
        IWarcraftClientMythicRaidLeaderboardApi,
        IWarcraftClientPetApi,
        IWarcraftClientPlayableClassApi,
        IWarcraftClientPlayableRaceApi,
        IWarcraftClientRealmApi
    {
    }
}
