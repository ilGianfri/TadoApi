using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Converters
{
    /// <summary>
    /// Converts the duration mode type returned by the Tado API to the DurationModes enumerator in this project
    /// </summary>
    [JsonConverter(typeof(DurationModeConverter))]
    public enum DurationModes
    {
        UntilNextManualChange,
        UntilNextTimedEvent,
        Timer
    }

    public class DurationModeConverter : JsonConverter<DurationModes>
    {
        public override DurationModes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string enumString = reader.GetString();

            DurationModes? durationMode = null;
            switch (enumString)
            {
                case "MANUAL":
                    durationMode = DurationModes.UntilNextManualChange;
                    break;

                case "TADO_MODE":
                    durationMode = DurationModes.UntilNextTimedEvent;
                    break;

                case "TIMER":
                    durationMode = DurationModes.Timer;
                    break;
            }

            return durationMode ?? throw new JsonException($"Invalid duration mode: {enumString}");
        }

        public override void Write(Utf8JsonWriter writer, DurationModes value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case DurationModes.UntilNextManualChange:
                    writer.WriteStringValue("MANUAL");
                    break;

                case DurationModes.UntilNextTimedEvent:
                    writer.WriteStringValue("TADO_MODE");
                    break;

                case DurationModes.Timer:
                    writer.WriteStringValue("TIMER");
                    break;
            }
        }
    }
}
