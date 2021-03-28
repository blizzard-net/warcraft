using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Criteria for completing an achievement.
    /// </summary>
    public record Criteria
    {
        /// <summary>
        /// Gets the ID of the related achievement that is a criterion for completing the parent achievement.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether the criterion achievment has been completed.
        /// </summary>
        [JsonPropertyName("is_completed")]
        public bool IsCompleted { get; }

        /// <summary>
        /// Gets child criteria of the criterion achievment, if any.
        /// </summary>
        [JsonPropertyName("child_criteria")]
        public Criteria[] ChildCriteria { get; }

        /// <summary>
        /// Gets an amount associated with this criterion achievment, if any.
        /// </summary>
        [JsonPropertyName("amount")]
        public ulong? Amount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Criteria"/> class.
        /// </summary>
        /// <param name="id">The ID of the related achievement that is a criterion for completing the parent achievement.</param>
        /// <param name="isCompleted">A value indicating whether the criterion achievment has been completed.</param>
        /// <param name="childCriteria">Child criteria of the criterion achievment, if any.</param>
        /// <param name="amount">An amount associated with this criterion achievment, if any.</param>
        [JsonConstructor]
        public Criteria(int id, bool isCompleted, Criteria[] childCriteria, ulong? amount)
        {
            Id = id;
            IsCompleted = isCompleted;
            ChildCriteria = childCriteria;
            Amount = amount;
        }
    }
}
