using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     Represents the response body for a failed Blizzard API request.
    /// </summary>
    public class RequestError
    {
        /// <summary>
        ///     The HTTP status code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        ///     The HTTP status code description.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The details of why the request failed.
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; }
        
        // Reason and status properties are used for a 404 status code.
        // Blizzard sends two types of responses back. 404 and a 'catch all'.
        // The 404 response has a reason and status properties.
        // The 'catch all' has code, type and detail.
        // For simplicty we can merge the two together.
        [JsonProperty("reason")]
        private string Reason 
        { 
            set
            { 
                Detail = value; 
            } 
        }

        [JsonProperty("status")]
        private string Status 
        {
            set
            {
                Code = "404";
                Type = "Not Found.";
            }
        }
    }
}