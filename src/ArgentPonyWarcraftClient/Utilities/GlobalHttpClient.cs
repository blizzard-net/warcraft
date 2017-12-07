using System.Net.Http;

namespace ArgentPonyWarcraftClient.Utilities
{
    /// <summary>
    ///     HttpClient is intended to be instantiated once and re-used throughout the life of an application.
    ///     Especially in server applications, creating a new HttpClient instance for every request will exhaust the
    ///     number of sockets available under heavy loads. This will result in SocketException errors.
    /// </summary>
    public static class GlobalHttpClient
    {
        private static HttpClient _instance;

        /// <summary>
        ///     Gets the current HttpClient instance.
        /// </summary>
        public static HttpClient Instance => _instance ?? (_instance = new HttpClient());
    }
}