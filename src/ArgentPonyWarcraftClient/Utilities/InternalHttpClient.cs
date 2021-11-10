using System.Net.Http.Headers;

namespace ArgentPonyWarcraftClient;

/// <summary>
///     An internal HttpClient singleton class to be used for the lifetime of the application.
/// </summary>
internal static class InternalHttpClient
{
    private static HttpClient s_instance;

    /// <summary>
    ///     Gets the current HttpClient instance.
    /// </summary>
    public static HttpClient Instance
    {
        get
        {
            if (s_instance != null)
            {
                return s_instance;
            }
            else
            {
                s_instance = new HttpClient();
                s_instance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return s_instance;
            }
        }
    }
}
