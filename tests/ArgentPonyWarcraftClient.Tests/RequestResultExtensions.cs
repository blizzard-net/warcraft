using System.Text.Json;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;

namespace ArgentPonyWarcraftClient.Tests
{
    public static class RequestResultExtensions
    {
        /// <summary>
        /// Asserts that the <paramref name="requestResult"/> matches the
        /// specified <paramref name="expectedJsonContent"/>.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="requestResult">The request result.</param>
        /// <param name="expectedJsonContent">The expected JSON content.</param>
        public static void ShouldMatchJsonContent<T>(this RequestResult<T> requestResult, string expectedJsonContent)
        {
            var actualJsonValue = JObject.Parse(JsonSerializer.Serialize(requestResult.Value, new JsonSerializerOptions
            {
                IgnoreNullValues = true
            }));
            var expectedJsonValue = JObject.Parse(expectedJsonContent);

            actualJsonValue.Should().BeEquivalentTo(expectedJsonValue);
        }
    }
}
