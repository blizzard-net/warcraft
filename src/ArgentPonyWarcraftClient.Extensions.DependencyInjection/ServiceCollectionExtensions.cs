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
            throw new NotImplementedException();
        }
    }
}
