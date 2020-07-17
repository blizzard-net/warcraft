using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A battle pet type.
    /// </summary>
    public class BattlePetType
    {
        /// <summary>
        /// Gets the ID of the battle pet type.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the type of the battle pet type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the name of the battle pet type.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
