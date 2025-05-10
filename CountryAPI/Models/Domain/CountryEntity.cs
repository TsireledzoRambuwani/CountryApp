using Newtonsoft.Json;

namespace CountryAPI.Models.Domain
{
    public class CountryEntity
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("capital", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Capital { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("maps")]
        public Map Maps { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

        [JsonProperty("flags")]
        public Flag Flags { get; set; }

    }
}
