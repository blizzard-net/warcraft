namespace ArgentPonyWarcraftClient;

/// <summary>
/// A JSON converter that reads and writes dates formatted as Unix epoch time milliseconds.
/// </summary>
internal class EpochConverter : JsonConverter<DateTimeOffset>
{
    /// <inheritdoc />
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTimeOffset.FromUnixTimeMilliseconds(reader.GetInt64());
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, DateTimeOffset dateTimeOffsetValue, JsonSerializerOptions options)
    {
        writer.WriteStringValue(dateTimeOffsetValue.ToUnixTimeMilliseconds().ToString("N0"));
    }
}
