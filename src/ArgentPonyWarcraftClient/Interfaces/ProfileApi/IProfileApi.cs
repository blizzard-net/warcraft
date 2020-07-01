namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Profile APIs.
    /// </summary>
    public interface IProfileApi :
        ICharacterAchievementsApi,
        ICharacterCollectionsApi,
        ICharacterMythicKeystoneProfileApi,
        ICharacterProfileApi
    {
    }
}
