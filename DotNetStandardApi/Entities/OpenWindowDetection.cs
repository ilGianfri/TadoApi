using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Open Window Detection settings
    /// </summary>
    public partial class OpenWindowDetection
    {
        [JsonPropertyName("supported")]
        public bool Supported { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("timeoutInSeconds")]
        public long? TimeoutInSeconds { get; set; }
    }
}