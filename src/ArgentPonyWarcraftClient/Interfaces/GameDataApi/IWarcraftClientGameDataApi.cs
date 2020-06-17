namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Game Data APIs.
    /// </summary>
    public interface IWarcraftClientGameDataApi :
        IWarcraftClientAchievementApi,
        IWarcraftClientAuctionHouseApi,
        IWarcraftClientConnectedRealmApi,
        IWarcraftClientItemApi,
        IWarcraftClientJournalApi,
        IWarcraftClientMountApi,
        IWarcraftClientPetApi,
        IWarcraftClientPlayableClassApi,
        IWarcraftClientPlayableRaceApi,
        IWarcraftClientRealmApi
    {
    }
}
