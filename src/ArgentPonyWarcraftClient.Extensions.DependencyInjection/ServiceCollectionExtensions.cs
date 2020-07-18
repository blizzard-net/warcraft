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
                .AddProfileApiServices();

            return services;
        }

        private static IServiceCollection AddProfileApiServices(this IServiceCollection services)
        {
            services.AddTransientWithFactory<IProfileApi, IWarcraftClient>();

            return services.AddTransientWithFactory<ICharacterAchievementsApi, IProfileApi>()
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
