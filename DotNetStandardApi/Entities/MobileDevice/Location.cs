using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities.MobileDevice
{
    /// <summary>
    /// Contains the location of a device
    /// </summary>
    public class Location
    {
        [JsonPropertyName("stale")]
        public bool Stale { get; set; }

        [JsonPropertyName("atHome")]
        public bool AtHome { get; set; }

        [JsonPropertyName("bearingFromHome")]
        public BearingFromHome BearingFromHome { get; set; }

        [JsonPropertyName("relativeDistanceFromHomeFence")]
        public long RelativeDistanceFromHomeFence { get; set; }
    }
}