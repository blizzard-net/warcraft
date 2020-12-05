using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Assertions;

namespace ArgentPonyWarcraftClient.Integration.Tests.TestUtilities
{
    internal static class RequestResultAssertionExtensions
    {
        /// <summary>
        /// Asserts that the current <see cref="RequestResult{TValue}.Value"/> matches the
        /// JSON content for the specified <paramref name="blizzardUri"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestResultShould">
        /// The current <see cref="RequestResultAssertions{T}"/> instance.
        /// </param>
        /// <param name="blizzardUri">
        /// The request URI to retrieve the JSON response from that the
        /// <see cref="RequestResult{TValue}.Value"/> should match.
        /// </param>
        /// <returns>
        /// An asynchronous operation.
        /// </returns>
        public static async Task BeEquivalentToBlizzardResponseAsync<T>(this RequestResultAssertions<T> requestResultShould,
            string blizzardUri)
        {
            RawBlizzardClient client = ClientFactory.BuildRawBlizzardClient();

            string response = await client.GetRawBlizzardResponseAsync(blizzardUri);

            requestResultShould.BeEquivalentToJson(response);
        }
    }
}
