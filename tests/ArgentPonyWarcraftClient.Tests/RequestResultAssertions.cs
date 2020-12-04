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

        /// <summary>
        /// Asserts that the <see cref="RequestResult{T}"/> is a successful request.<para />
        /// Verifies that <see cref="RequestResult{T}.Success"/> is true and <see cref="RequestResult{T}.Error"/>
        /// is null.
        /// </summary>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="because"/>.
        /// </param>
        /// <returns>
        /// A <see cref="RequestResultAssertions{T}"/> for chaining assertions.
        /// </returns>
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

        /// <summary>
        /// Asserts that the <see cref="RequestResult{T}.Value"/> matches the given JSON string.
        /// </summary>
        /// <param name="expectedJson">
        /// The JSON that should be matched.
        /// </param>
        /// <param name="because">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="becauseArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="because"/>.
        /// </param>
        /// <returns>
        /// A <see cref="RequestResultAssertions{T}"/> for chaining assertions.
        /// </returns>
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
