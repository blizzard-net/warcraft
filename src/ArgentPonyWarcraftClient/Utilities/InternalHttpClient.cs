using System.Net.Http;
using System.Net.Http.Headers;

namespace ArgentPonyWarcraftClient;

/// <summary>
///     An internal HttpClient singleton class to be used for the lifetime of the application.
/// </summary>
internal static class InternalHttpClient
{
    private static HttpClient _instance;

    /// <summary>
    ///     Gets the current HttpClient instance.
    /// </summary>
    public static HttpClient Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }
            else
            {
                _instance = new HttpClient();
                _instance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return _instance;
            }
        }
    }
}
