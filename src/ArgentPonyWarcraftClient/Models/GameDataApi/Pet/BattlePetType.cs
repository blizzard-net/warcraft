using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A battle pet type.
    /// </summary>
    public class BattlePetType
    {
        /// <summary>
        /// Gets the ID of the battle pet type.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the type of the battle pet type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the name of the battle pet type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
