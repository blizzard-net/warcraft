namespace ArgentPonyWarcraftClient;

/// <summary>
///     Represents the response body for a failed Blizzard API request.
/// </summary>
public class RequestError
{
    /// <summary>
    ///     The HTTP status code.
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    ///     The HTTP status code description.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    ///     The details of why the request failed.
    /// </summary>
    [JsonPropertyName("detail")]
    public string Detail { get; set; }

    // Blizzard sends two types of responses back. 404 and a 'catch all'.
    // The 404 response has a reason and status properties.
    // The 'catch all' has code, type and detail properties.
    // For simplicty we can merge the two together.
    [JsonPropertyName("reason")]
    private string Reason
    {
        set
        {
            Detail = value;
        }
    }

    [JsonPropertyName("status")]
    private string Status
    {
        set
        {
            Code = 404;
            Type = "Not Found.";
        }
    }
}
