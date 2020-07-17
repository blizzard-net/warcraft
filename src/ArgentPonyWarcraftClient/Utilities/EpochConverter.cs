using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A JSON converter that reads and writes dates formatted as Unix epoch time.
    /// </summary>
    internal class EpochConverter : JsonConverter<DateTime>
    {
        /// <summary>
        /// The base date for the Unix epoch.
        /// </summary>
        private static readonly DateTime s_epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <inheritdoc />
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return s_epochStart.AddMilliseconds(reader.GetInt64());
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, DateTime dateTimeValue, JsonSerializerOptions options)
        {
            writer.WriteStringValue((dateTimeValue - s_epochStart).TotalMilliseconds.ToString("N0"));
        }
    }
}
