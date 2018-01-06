using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A JSON.NET converter that reads and writes dates formatted as Unix epoch time.
    /// </summary>
    internal class JsonEpochConverter : DateTimeConverterBase
    {
        /// <summary>
        /// The base date for the Unix epoch.
        /// </summary>
        private static readonly DateTime SEpochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>
        /// The object value.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            if (long.TryParse(reader.Value.ToString(), out long milliseconds))
            {
                return SEpochStart.AddMilliseconds(milliseconds);
            }

            return DateTime.Parse(reader.Value.ToString());
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(((DateTime)value - SEpochStart).TotalMilliseconds.ToString("N0"));
        }
    }
}
