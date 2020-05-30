using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A JSON converter for the <see cref="TimeLeft"/> enumeration.
    /// </summary>
    internal class TimeLeftConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimeLeft) || t == typeof(TimeLeft?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch (value)
            {
                case "SHORT":
                    return TimeLeft.Short;
                case "VERY_LONG":
                    return TimeLeft.VeryLong;
            }

            throw new Exception("Cannot unmarshal type TimeLeft");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TimeLeft)untypedValue;

            switch (value)
            {
                case TimeLeft.Short:
                    serializer.Serialize(writer, "SHORT");
                    return;
                case TimeLeft.VeryLong:
                    serializer.Serialize(writer, "VERY_LONG");
                    return;
            }

            throw new Exception("Cannot marshal type TimeLeft");
        }

        public static readonly TimeLeftConverter Singleton = new TimeLeftConverter();
    }
}
