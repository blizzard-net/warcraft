using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentSquire
{
    /// <summary>
    /// A guild news event.
    /// </summary>
    public class News
    {
        /// <summary>
        /// Gets or sets the type of news.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the character name.
        /// </summary>
        [JsonProperty("character")]
        public string Character { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the bonus lists.
        /// </summary>
        [JsonProperty("bonusLists")]
        public IList<int> BonusLists { get; set; }

        /// <summary>
        /// Gets or sets the achievement.
        /// </summary>
        [JsonProperty("achievement")]
        public Achievement Achievement { get; set; }
    }
}
