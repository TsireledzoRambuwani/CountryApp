using Newtonsoft.Json;

namespace CountryAPI.Models.Domain
{
    public class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }


    }

}
