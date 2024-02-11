using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities.MobileDevice
{
    /// <summary>
    /// Contains the coordinates relative to the home location where Tado is being used
    /// </summary>
    public partial class BearingFromHome
    {
        [JsonPropertyName("degrees")]
        public double Degrees { get; set; }

        [JsonPropertyName("radians")]
        public double Radians { get; set; }
    }
}
