using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// Tooltip parameters.
    /// </summary>
    public class TooltipParams
    {
        /// <summary>
        /// Gets the timewalker level.
        /// </summary>
        [JsonProperty(PropertyName = "timewalkerLevel")]
        public int TimewalkerLevel { get; private set; }
    }
}
