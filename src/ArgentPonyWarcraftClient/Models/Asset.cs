using System;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        /// <summary>
        /// Gets a URI for retrieving the asset value.
        /// </summary>
        [JsonPropertyName("value")]
        public Uri Value { get; private set; }
    }
}
