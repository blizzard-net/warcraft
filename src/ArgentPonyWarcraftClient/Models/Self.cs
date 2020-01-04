using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A self-reference.
    /// </summary>
    public class Self
    {
        /// <summary>
        /// Gets a URI for retrieving the data for this object.
        /// </summary>
        [JsonProperty("href")]
        public Uri Href { get; private set; }
    }
}
