using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A media asset.
    /// </summary>
    public record Asset
    {
        /// <summary>
        /// Gets the key of the asset.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; }

        /// <summary>
        /// Gets a URI for retrieving the asset value.
        /// </summary>
        [JsonPropertyName("value")]
        public Uri Value { get; }

        /// <summary>
        /// Gets the file data id for the asset.
        /// </summary>
        [JsonPropertyName("file_data_id")]
        public long FileDataId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset"/> class.
        /// </summary>
        /// <param name="key">The key of the asset.</param>
        /// <param name="value">A URI for retrieving the asset value.</param>
        /// <param name="fileDataId">The file data id for the asset.</param>
        [JsonConstructor]
        public Asset(string key, Uri value, long fileDataId)
        {
            Key = key;
            Value = value;
            FileDataId = fileDataId;
        }
    }
}
