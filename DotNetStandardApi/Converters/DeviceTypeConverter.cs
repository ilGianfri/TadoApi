using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Converters
{
    /// <summary>
    /// Converts the Tado device type returned by the Tado API to the DeviceTypes enumerator in this project
    /// </summary>
    public class DeviceTypeConverter : JsonConverter<Enums.DeviceTypes>
    {
        public override void Write(Utf8JsonWriter writer, Enums.DeviceTypes value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Enums.DeviceTypes.Heating:
                    writer.WriteStringValue("HEATING");
                    break;

                case Enums.DeviceTypes.HotWater:
                    writer.WriteStringValue("HOT_WATER");
                    break;
            }
        }

        public override Enums.DeviceTypes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string enumString = reader.GetString();

            Enums.DeviceTypes? terminationType = null;
            switch (enumString)
            {
                case "HEATING":
                    terminationType = Enums.DeviceTypes.Heating;
                    break;

                case "HOT_WATER":
                    terminationType = Enums.DeviceTypes.HotWater;
                    break;
            }

            return terminationType ?? throw new JsonException();
        }
    }
}
