using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Contains information about a user
    /// </summary>
    public class User
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("homes")]
        public Home[] Homes { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("mobileDevices")]
        public MobileDevice.Item[] MobileDevices { get; set; }
    }
}