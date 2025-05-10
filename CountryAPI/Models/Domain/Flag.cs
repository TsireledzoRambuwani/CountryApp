using Newtonsoft.Json;

namespace CountryAPI.Models.Domain
{
    public class Flag
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }

        [JsonProperty("alt", NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }
    }
}
