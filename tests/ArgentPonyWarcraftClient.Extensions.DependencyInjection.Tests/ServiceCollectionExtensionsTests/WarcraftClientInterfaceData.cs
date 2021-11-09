using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArgentPonyWarcraftClient.Extensions.DependencyInjection.Tests.ServiceCollectionExtensionsTests;

/// <summary>
/// Test data that identifies all API client interfaces
/// from the ArgentPonyWarcraftClient namespace.
/// </summary>
public class WarcraftClientInterfaceData : IEnumerable<object[]>
{
    private static readonly IReadOnlyCollection<Type> ClientInterfaces = GetWarcraftClientInterfaces()
        .ToImmutableArray();

    public IEnumerator<object[]> GetEnumerator()
    {
        return ClientInterfaces.Select(type => new object[] { type }).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

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
}
