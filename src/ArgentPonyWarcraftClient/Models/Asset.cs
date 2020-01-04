using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A media asset.
    /// </summary>
    public class Asset
    {
        /// <summary>
        /// Gets the key of the asset.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; private set; }

        /// <summary>
        /// Gets a URI for retrieving the asset value.
        /// </summary>
        [JsonProperty("value")]
        public Uri Value { get; private set; }
    }
}
