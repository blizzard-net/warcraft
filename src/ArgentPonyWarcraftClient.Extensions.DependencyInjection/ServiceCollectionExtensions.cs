using System;
using Microsoft.Extensions.DependencyInjection;

namespace ArgentPonyWarcraftClient.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions to the <see cref="IServiceCollection"/> for registering
    /// the World of Warcraft Game Data and Profile API clients.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWarcraftClients(this IServiceCollection services, string clientId, string clientSecret)
        {
            throw new NotImplementedException();
        }

        public static IServiceCollection AddWarcraftClients(this IServiceCollection services, string clientId,
            string clientSecret, Region region, Locale locale)
        {
            services.AddHttpClient("ArgentPonyWarcraftClient.WarcraftClient.HttpClient")
                .AddTypedClient(httpClient =>
                    new WarcraftClient(clientId, clientSecret, region, locale, httpClient));

            services.AddTransientWithFactory<IWarcraftClient, WarcraftClient>()
                .AddProfileApiServices()
                .AddGameDataApiServices();

            return services;
        }

        private static IServiceCollection AddProfileApiServices(this IServiceCollection services)
        {
            services.AddTransientWithFactory<IProfileApi, IWarcraftClient>();

            return services.AddTransientWithFactory<IAccountProfileApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterAchievementsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterAppearanceApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterCollectionsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterEncountersApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterEquipmentApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterHunterPetsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterMythicKeystoneProfileApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterProfessionsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterProfileApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterPvpApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterQuestsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterReputationsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterSpecializationsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterStatisticsApi, IProfileApi>()
                .AddTransientWithFactory<ICharacterTitlesApi, IProfileApi>()
                .AddTransientWithFactory<IGuildApi, IProfileApi>();
        }

        private static IServiceCollection AddGameDataApiServices(this IServiceCollection services)
        {
            services.AddTransientWithFactory<IGameDataApi, IWarcraftClient>();

            return services.AddTransientWithFactory<IAchievementApi, IGameDataApi>()
                .AddTransientWithFactory<IAuctionHouseApi, IGameDataApi>()
                .AddTransientWithFactory<IAzeriteEssenceApi, IGameDataApi>()
                .AddTransientWithFactory<IConnectedRealmApi, IGameDataApi>()
                .AddTransientWithFactory<ICreatureApi, IGameDataApi>()
                .AddTransientWithFactory<IGuildCrestApi, IGameDataApi>()
                .AddTransientWithFactory<IItemApi, IGameDataApi>()
                .AddTransientWithFactory<IJournalApi, IGameDataApi>()
                .AddTransientWithFactory<IMountApi, IGameDataApi>()
                .AddTransientWithFactory<IMythicKeystoneAffixApi, IGameDataApi>()
                .AddTransientWithFactory<IMythicKeystoneDungeonApi, IGameDataApi>()
                .AddTransientWithFactory<IMythicKeystoneLeaderboardApi, IGameDataApi>()
                .AddTransientWithFactory<IMythicRaidLeaderboardApi, IGameDataApi>()
                .AddTransientWithFactory<IPetApi, IGameDataApi>()
                .AddTransientWithFactory<IPlayableClassApi, IGameDataApi>()
                .AddTransientWithFactory<IPlayableRaceApi, IGameDataApi>()
                .AddTransientWithFactory<IPlayableSpecializationApi, IGameDataApi>()
                .AddTransientWithFactory<IPowerTypeApi, IGameDataApi>()
                .AddTransientWithFactory<IProfessionApi, IGameDataApi>()
                .AddTransientWithFactory<IPvpSeasonApi, IGameDataApi>()
                .AddTransientWithFactory<IPvpTierApi, IGameDataApi>()
                .AddTransientWithFactory<IQuestApi, IGameDataApi>()
                .AddTransientWithFactory<IRealmApi, IGameDataApi>()
                .AddTransientWithFactory<IRegionApi, IGameDataApi>()
                .AddTransientWithFactory<IReputationsApi, IGameDataApi>()
                .AddTransientWithFactory<ISpellApi, IGameDataApi>()
                .AddTransientWithFactory<ITalentApi, IGameDataApi>()
                .AddTransientWithFactory<ITitleApi, IGameDataApi>()
                .AddTransientWithFactory<IWowTokenApi, IGameDataApi>();
        }

        private static IServiceCollection AddTransientWithFactory<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService

        {
            return services.AddTransient<TService>(serviceProvider =>
                serviceProvider.GetRequiredService<TImplementation>()
            );
        }
    }
}
