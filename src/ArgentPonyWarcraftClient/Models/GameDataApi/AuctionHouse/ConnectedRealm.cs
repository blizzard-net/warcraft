using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A connected realm.
    /// </summary>
    public class ConnectedRealm
    {
        /// <summary>
        /// Gets the URI of the connected realm.
        /// </summary>
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }
}
