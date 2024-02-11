using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Information about one Tado device
    /// </summary>
    public class Device
    {
        [JsonPropertyName("deviceType")]
        public string DeviceType { get; set; }

        [JsonPropertyName("serialNo")]
        public string SerialNo { get; set; }

        [JsonPropertyName("shortSerialNo")]
        public string ShortSerialNo { get; set; }

        [JsonPropertyName("currentFwVersion")]
        public string CurrentFwVersion { get; set; }

        [JsonPropertyName("connectionState")]
        public ConnectionState ConnectionState { get; set; }

        [JsonPropertyName("characteristics")]
        public Characteristics Characteristics { get; set; }

        [JsonPropertyName("duties")]
        public string[] Duties { get; set; }

        [JsonPropertyName("mountingState")]
        public MountingState MountingState { get; set; }

        [JsonPropertyName("batteryState")]
        public string BatteryState { get; set; }
        
        /// <summary>
        /// Indicates if child lock is enabled or disabled on the Tado device
        /// </summary>
        [JsonPropertyName("childLockEnabled")]
        public bool? ChildLockEnabled { get; set; }
    }
}