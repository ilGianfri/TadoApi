using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities.MobileDevice
{
    /// <summary>
    /// Contains settings specific to the device
    /// </summary>
    public class Settings
    {
        [JsonPropertyName("geoTrackingEnabled")]
        public bool GeoTrackingEnabled { get; set; }
    }
}