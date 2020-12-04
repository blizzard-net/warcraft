using System.Linq;
using System.Text.Json;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using Newtonsoft.Json.Linq;

namespace ArgentPonyWarcraftClient.Tests
{
    public class RequestResultAssertions<T> : ReferenceTypeAssertions<RequestResult<T>, RequestResultAssertions<T>>
    {
        public RequestResultAssertions(RequestResult<T> instance)
        {
            Subject = instance;
        }

        /// <inheritdoc />
        protected override string Identifier => $"RequestResult<{typeof(T).Name}>";

        public RequestResultAssertions<T> BeSuccessfulRequest(string because = "", params object[] becauseArgs)
        {
            using (new AssertionScope())
            {
                NotBeNull();
                Subject?.Success.Should().BeTrue();
                Subject?.Error.Should().BeNull();
            }

            return this;
        }

        public void BeEquivalentToJson(string expectedJson, string because = "", params object[] becauseArgs)
        {
            // Compare values as JObjects, removing null values on both actual and result. This
            // addresses an issues where objects like spell tooltips sometimes use a null value and sometimes
            // exclude a property, e.g. { "cast_time": "Passive" } vs. { "cast_time": "Instant", "power_cost": null }
            NotBeNull();

            var actualJsonValue = RemoveNullProperties(JObject.Parse(JsonSerializer.Serialize<T>(Subject.Value)));
            var expectedJsonValue = RemoveNullProperties(JObject.Parse(expectedJson));

            actualJsonValue.Should().BeEquivalentTo(expectedJsonValue);
        }

        private static JObject RemoveNullProperties(JObject jObject)
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
