using System.Linq;
using System.Text.Json;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;

namespace ArgentPonyWarcraftClient.Tests
{
    public static class RequestResultExtensions
    {
        public static RequestResultAssertions<T> Should<T>(this RequestResult<T> subject) =>
            new RequestResultAssertions<T>(subject);
    }
}
