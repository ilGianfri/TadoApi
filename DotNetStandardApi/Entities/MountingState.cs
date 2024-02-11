using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// State of the mounted Tado device
    /// </summary>
    public class MountingState
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("timestamp")]
        public System.DateTime Timestamp { get; set; }
    }
}