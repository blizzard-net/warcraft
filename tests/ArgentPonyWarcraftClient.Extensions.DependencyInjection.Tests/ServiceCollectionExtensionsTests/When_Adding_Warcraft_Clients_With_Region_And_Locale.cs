using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Abstractions;

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

        public static IEnumerable<object[]> LocalAndRegionPairsWithClientInterfaces
        {
            get
            {
                foreach (var clientInterface in GetWarcraftClientInterfaces())
                {
                    foreach (var localeAndRegionPair in LocaleAndRegionPairs)
                    {
                        yield return localeAndRegionPair.Concat(new [] { clientInterface }).ToArray();
                    }
                }
            }
        }

        [Theory]
        [MemberData(nameof(LocalAndRegionPairsWithClientInterfaces))]
        public void Then_All_Warcraft_Interfaces_Are_Resolved_To_A_WarcraftClient_Instance(
            LocaleAndRegionPair localeAndRegion, Type clientInterfaceToResolve)
        {
            _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndRegion.Region,
                localeAndRegion.Locale);

            IServiceProvider serviceProvider = _services.BuildServiceProvider();

            var client = serviceProvider.GetRequiredService(clientInterfaceToResolve);

            Assert.IsType<WarcraftClient>(client);
        }

        [Theory]
        [MemberData(nameof(LocaleAndRegionPairs))]
        public void Then_Warcraft_Client_Is_Created_With_Provided_Client_Keys_And_Region_And_Locale(
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
        public void Then_Warcraft_Client_Uses_HttpClient_From_Http_Client_Factory(LocaleAndRegionPair localeAndregion)
        {
            _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndregion.Region,
                localeAndregion.Locale);

            IServiceProvider serviceProvider = _services.BuildServiceProvider();

            var warcraftClient = serviceProvider.GetRequiredService<WarcraftClient>();

            Assert.NotSame(InternalHttpClient.Instance, warcraftClient.Client);
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
