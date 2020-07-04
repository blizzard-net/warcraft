namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Profile APIs.
    /// </summary>
    public interface IProfileApi :
        ICharacterAchievementsApi,
        ICharacterAppearanceApi,
        ICharacterCollectionsApi,
        ICharacterEquipmentApi,
        ICharacterHunterPetsApi,
        ICharacterMythicKeystoneProfileApi,
        ICharacterProfileApi
    {
    }
}
