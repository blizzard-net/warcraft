using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// A raid.
    /// </summary>
    public class Raid
    {
        /// <summary>
        /// Gets or sets the raid name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the completion status in LFR mode.
        /// </summary>
        [JsonProperty("lfr")]
        public int Lfr { get; set; }

        /// <summary>
        /// Gets or sets the completion status in Normal mode.
        /// </summary>
        [JsonProperty("normal")]
        public int Normal { get; set; }

        /// <summary>
        /// Gets or sets the completion status in Heroic mode.
        /// </summary>
        [JsonProperty("heroic")]
        public int Heroic { get; set; }

        /// <summary>
        /// Gets or sets the completion status in Mythic mode.
        /// </summary>
        [JsonProperty("mythic")]
        public int Mythic { get; set; }

        /// <summary>
        /// Gets or sets the raid ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets progression information for the raid bosses.
        /// </summary>
        [JsonProperty("bosses")]
        public IList<ProgressionBoss> Bosses { get; set; }
    }
}
