using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ArgentPonyWarcraftClient.Extensions.DependencyInjection.Tests.ServiceCollectionExtensionsTests
{
    public class When_Adding_Warcraft_Clients_With_Region_And_Locale
    {
        private readonly IServiceCollection _services;

        public When_Adding_Warcraft_Clients_With_Region_And_Locale()
        {
            _services = new ServiceCollection();
        }

        public static IEnumerable<object[]> LocaleAndRegionPairs
        {
            get
            {
                var locales = Enum.GetValues(typeof(Locale))
                    .Cast<Locale>();

                return locales.Select(locale => new object[]
                {
                    new LocaleAndRegionPair(locale)
                });
            }
        }

        public static IEnumerable<object[]> ClientInterfacesWithLocaleAndRegionPair
        {
            get
            {
                foreach (var clientInterface in GetWarcraftClientInterfaces())
                {
                    foreach (var localeAndRegionPair in LocaleAndRegionPairs)
                    {
                        yield return new object[] { clientInterface }.Concat(localeAndRegionPair).ToArray();
                    }
                }
            }
        }

        [Theory]
        [MemberData(nameof(ClientInterfacesWithLocaleAndRegionPair))]
        public void Then_All_Warcraft_Interfaces_Are_Resolved_To_A_WarcraftClient_Instance(
            Type clientInterfaceToResolve, LocaleAndRegionPair localeAndRegion)
        {
            _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndRegion.Region,
                localeAndRegion.Locale);

            IServiceProvider serviceProvider = _services.BuildServiceProvider();

            var client = serviceProvider.GetRequiredService(clientInterfaceToResolve);

            Assert.IsType<WarcraftClient>(client);
        }

        [Theory]
        [MemberData(nameof(LocaleAndRegionPairs))]
        public void Then_WarcraftClient_Is_Created_With_Provided_Client_Credentials_And_Region_And_Locale(
            LocaleAndRegionPair localeAndRegion)
        {
            const string expectedClientId = "the client Id";
            const string expectedClientSecret = "the client secret";

            _services.AddWarcraftClients(expectedClientId, expectedClientSecret, localeAndRegion.Region,
                localeAndRegion.Locale);

            IServiceProvider serviceProvider = _services.BuildServiceProvider();

            var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

            Assert.Equal(expectedClientId, warcraftClient.ClientId);
            Assert.Equal(expectedClientSecret, warcraftClient.ClientSecret);
            Assert.Equal(localeAndRegion.Region, warcraftClient.Region);
            Assert.Equal(localeAndRegion.Locale, warcraftClient.Locale);
        }

        [Theory]
        [MemberData(nameof(LocaleAndRegionPairs))]
        public void Then_WarcraftClient_Does_Not_Use_InternalHttpClient(LocaleAndRegionPair localeAndregion)
        {
            _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndregion.Region,
                localeAndregion.Locale);

            IServiceProvider serviceProvider = _services.BuildServiceProvider();

            var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

            Assert.NotSame(InternalHttpClient.Instance, warcraftClient.Client);
        }

        [Theory]
        [MemberData(nameof(LocaleAndRegionPairs))]
        public void Then_WarcraftClient_Is_Configured_To_Accept_Json_Content(LocaleAndRegionPair localeAndRegion)
        {
            _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndRegion.Region,
                localeAndRegion.Locale);

            IServiceProvider serviceProvider = _services.BuildServiceProvider();

            var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();
            var acceptsJsonContent =
                warcraftClient.Client.DefaultRequestHeaders.Accept.Contains(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            Assert.True(acceptsJsonContent);
        }

        private static IEnumerable<Type> GetWarcraftClientInterfaces()
        {
            return typeof(IWarcraftClient).Assembly.GetTypes()
                .Where(type =>
                    type.IsInterface &&
                    TypeNameEndsWithApiOrClient(type)
                );
        }

        private static bool TypeNameEndsWithApiOrClient(Type type)
        {
            return Regex.IsMatch(type.FullName ?? string.Empty, @"I\w+(Api|Client)$");
        }

        public class LocaleAndRegionPair
        {
            public LocaleAndRegionPair(Locale locale)
            {
                Locale = locale;
            }

            public Region Region => Locale.GetRegionForLocale();

            public Locale Locale { get; }
        }
    }
}
