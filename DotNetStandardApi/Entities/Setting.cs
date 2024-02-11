using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// The current state of a Tado device
    /// </summary>
    public partial class Setting
    {
        /// <summary>
        /// Type of Tado device
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(Converters.DeviceTypeConverter))]
        public Enums.DeviceTypes? DeviceType { get; set; }

        /// <summary>
        /// The powerstate of the Tado device
        /// </summary>
        [JsonPropertyName("power")]
        [JsonConverter(typeof(Converters.PowerStatesConverter))]
        public Enums.PowerStates? Power { get; set; }

        /// <summary>
        /// The temperature the Tado device is set to change the zone to
        /// </summary>
        [JsonPropertyName("temperature")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Temperature Temperature { get; set; }
    }
}