﻿namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Profile APIs.
    /// </summary>
    public interface IProfileApi :
        ICharacterAchievementsApi,
        ICharacterAppearanceApi,
        ICharacterCollectionsApi,
        ICharacterHunterPetsApi,
        ICharacterMythicKeystoneProfileApi,
        ICharacterProfileApi
    {
    }
}
