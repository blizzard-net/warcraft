namespace ArgentPonyWarcraftClient;

/// <summary>
/// A JSON converter that reads and writes timespans formatted as milliseconds.
/// </summary>
internal class MillisecondTimeSpanConverter : JsonConverter<TimeSpan>
{
    /// <inheritdoc />
    public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return TimeSpan.FromMilliseconds(reader.GetInt64());
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, TimeSpan timeSpanValue, JsonSerializerOptions options)
    {
        writer.WriteStringValue(timeSpanValue.TotalMilliseconds.ToString("N0"));
    }
}
