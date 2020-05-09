﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.GameData
{
    /// <summary>
    /// A game expansion.
    /// </summary>
    public partial class JournalExpansion
    {
        /// <summary>
        /// Gets links for the expansion.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the expansion.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the expansion.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the dungeons that belong to the expansion.
        /// </summary>
        [JsonProperty("dungeons")]
        public Dungeon[] Dungeons { get; set; }

        /// <summary>
        /// Gets the raids that belong to the expansion.
        /// </summary>
        [JsonProperty("raids")]
        public Raid[] Raids { get; set; }
    }
}
