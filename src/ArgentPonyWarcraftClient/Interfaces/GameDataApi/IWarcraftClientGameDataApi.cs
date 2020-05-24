namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Game Data APIs.
    /// </summary>
    public interface IWarcraftClientGameDataApi :
        IWarcraftClientAchievementApi,
        IWarcraftClientAuctionHouseApi,
        IWarcraftClientJournalApi,
        IWarcraftClientPetApi
    {
    }
}
