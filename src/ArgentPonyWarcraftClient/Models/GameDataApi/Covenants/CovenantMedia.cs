using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Media for a covenant.
    /// </summary>
    public class CovenantMedia
    {
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("assets")]
        public Asset[] Assets { get; set; }
    }
}
