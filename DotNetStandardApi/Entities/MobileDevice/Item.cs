using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities.MobileDevice
{
    /// <summary>
    /// Contains information about a mobile device set up to be used with Tado
    /// </summary>
    public class Item
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("deviceMetadata")]
        public Details MobileDeviceDetails { get; set; }
    }
}