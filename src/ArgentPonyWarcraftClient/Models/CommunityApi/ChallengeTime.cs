using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient.Community
{
    /// <summary>
    /// The time for a challenge mode dungeon.
    /// </summary>
    public class ChallengeTime
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        [JsonProperty("time")]
        public int Time { get; set; }

        /// <summary>
        /// Gets or sets the number of hours.
        /// </summary>
        [JsonProperty("hours")]
        public int Hours { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes.
        /// </summary>
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds.
        /// </summary>
        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        /// <summary>
        /// Gets or sets the number of milliseconds.
        /// </summary>
        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is positive.
        /// </summary>
        [JsonProperty("isPositive")]
        public bool IsPositive { get; set; }
    }
}
