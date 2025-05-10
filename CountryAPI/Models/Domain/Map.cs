using Newtonsoft.Json;

namespace CountryAPI.Models.Domain
{
    public class Map
    {
        [JsonProperty("googleMaps")]
        public Uri GoogleMaps { get; set; }

        [JsonProperty("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }
}