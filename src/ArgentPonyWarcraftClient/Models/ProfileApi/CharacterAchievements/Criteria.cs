using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Criteria for completing an achievement.
    /// </summary>
    public class Criteria
    {
        /// <summary>
        /// Gets the ID of the related achievement that is a criterion for completing the parent achievement.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the criterion achievment has been completed.
        /// </summary>
        [JsonProperty("is_completed")]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Gets child criteria of the criterion achievment, if any.
        /// </summary>
        [JsonProperty("child_criteria", NullValueHandling = NullValueHandling.Ignore)]
        public Criteria[] ChildCriteria { get; set; }

        /// <summary>
        /// Gets an amount associated with this criterion achievment, if any.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }
    }
}
