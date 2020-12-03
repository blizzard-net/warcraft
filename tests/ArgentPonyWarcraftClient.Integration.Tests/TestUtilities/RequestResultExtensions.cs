using System.Linq;
using System.Text.Json;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;

namespace ArgentPonyWarcraftClient.Integration.Tests
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
            // Compare values as JObjects, removing null values on both actual and result. This
            // addresses an issues where objects like spell tooltips sometimes use a null value and sometimes
            // exclude a property, e.g. { "cast_time": "Passive" } vs. { "cast_time": "Instant", "power_cost": null }
            var actualJsonValue = JObject.Parse(JsonSerializer.Serialize(requestResult.Value)).RemoveNullProperties();
            var expectedJsonValue = JObject.Parse(expectedJsonContent).RemoveNullProperties();

            actualJsonValue.Should().BeEquivalentTo(expectedJsonValue);
        }

        private static JObject RemoveNullProperties(this JObject jObject)
        {
            // Code inspired by: https://stackoverflow.com/a/60182337
            while (jObject.Descendants().Any(IsPropertyAndIsNullValue))
            {
                foreach (JToken token in jObject.Descendants().Where(IsPropertyAndIsNullValue).ToArray())
                {
                    token.Remove();
                }
            }
            return jObject;
        }

        private static bool IsPropertyAndIsNullValue(JToken jt) => jt.Type == JTokenType.Property && (jt.Values().All(a => a.Type == JTokenType.Null));
    }
}
