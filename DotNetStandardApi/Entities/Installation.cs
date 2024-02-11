using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// One Tado installation
    /// </summary>
    public class Installation
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("type")]
        public string CurrentType { get; set; }

        [JsonPropertyName("revision")]
        public long Revision { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("devices")]
        public Device[] Devices { get; set; }
    }
}
