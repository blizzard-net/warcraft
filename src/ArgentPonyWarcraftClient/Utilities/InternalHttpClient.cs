using System.Net.Http;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     An internal HttpClient singleton class to be used for the lifetime of the application.
    /// </summary>
    internal static class InternalHttpClient
    {
        private static HttpClient _instance;

        /// <summary>
        ///     Gets the current HttpClient instance.
        /// </summary>
        public static HttpClient Instance => _instance ?? (_instance = new HttpClient());
    }
}