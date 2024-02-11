using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Converters
{
    /// <summary>
    /// Converts the power state returned by the Tado API to the PowerStates enumerator in this project
    /// </summary>
    [JsonConverter(typeof(PowerStatesConverter))]
    public enum PowerStates
    {
        On,
        Off
    }

    public class PowerStatesConverter : JsonConverter<PowerStates>
    {
        public override PowerStates Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string enumString = reader.GetString();

            PowerStates? powerState = null;
            switch (enumString)
            {
                case "ON":
                    powerState = PowerStates.On;
                    break;

                case "OFF":
                    powerState = PowerStates.Off;
                    break;
            }

            return powerState ?? throw new JsonException($"Invalid power state: {enumString}");
        }

        public override void Write(Utf8JsonWriter writer, PowerStates value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case PowerStates.On:
                    writer.WriteStringValue("ON");
                    break;

                case PowerStates.Off:
                    writer.WriteStringValue("OFF");
                    break;
            }
        }
    }
}
