using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A character statistic.
    /// </summary>
    public record PrimaryStatistic
    {
        /// <summary>
        /// Gets the base statistic.
        /// </summary>
        [JsonPropertyName("base")]
        public int Base { get; }

        /// <summary>
        /// Gets the effective statistic.
        /// </summary>
        [JsonPropertyName("effective")]
        public int Effective { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryStatistic"/> class.
        /// </summary>
        /// <param name="base">The base statistic.</param>
        /// <param name="effective">The effective statistic.</param>
        [JsonConstructor]
        public PrimaryStatistic(int @base, int effective)
        {
            Base = @base;
            Effective = effective;
        }
    }
}
