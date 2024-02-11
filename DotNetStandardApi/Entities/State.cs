using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// State of a specific zone
    /// </summary>
    public class State
    {
        [JsonPropertyName("tadoMode")]
        public string TadoMode { get; set; }

        [JsonPropertyName("geolocationOverride")]
        public bool GeolocationOverride { get; set; }

        [JsonPropertyName("geolocationOverrideDisableTime")]
        public object GeolocationOverrideDisableTime { get; set; }

        [JsonPropertyName("preparation")]
        public object Preparation { get; set; }

        [JsonPropertyName("setting")]
        public Setting Setting { get; set; }

        [JsonPropertyName("overlayType")]
        public string OverlayType { get; set; }

        [JsonPropertyName("overlay")]
        public Overlay Overlay { get; set; }

        [JsonPropertyName("openWindow")]
        public object OpenWindow { get; set; }

        [JsonPropertyName("openWindowDetected")]
        public bool? OpenWindowDetected { get; set; }

        [JsonPropertyName("link")]
        public Link Link { get; set; }

        [JsonPropertyName("activityDataPoints")]
        public ActivityDataPoints ActivityDataPoints { get; set; }

        [JsonPropertyName("sensorDataPoints")]
        public SensorDataPoints SensorDataPoints { get; set; }
    }
}
