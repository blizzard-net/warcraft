using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        [Theory]
        [MemberData(nameof(LocaleAndRegionPairs))]
        public void Then_All_Warcraft_Interfaces_Are_Resolved_To_A_Warcraft_Client_Instance(LocaleAndRegionPair localeAndRegion)
        {
            _services.AddWarcraftClients("fake-client-id", "fake-client-secret", localeAndRegion.Region,
                localeAndRegion.Locale);

            IServiceProvider serviceProvider = _services.BuildServiceProvider();

            foreach (var clientInterface in GetWarcraftClientInterfaces())
            {
                var client = serviceProvider.GetRequiredService(clientInterface);

                Assert.IsType<WarcraftClient>(client);
            }
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

            public Region Region
            {
                get
                {
                    var fieldInfo = Locale.GetType().GetRuntimeField(Locale.ToString());
                    var localeRegionAttribute = fieldInfo.GetCustomAttribute<LocaleRegion>();

                    return localeRegionAttribute.Region;
                }
            }

            public Locale Locale { get; }
        }
    }
}
