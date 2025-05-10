
using CountryAPI.Models;
using CountryAPI.Models.Domain;
using CountryAPI.Repositories.Interface;
using Newtonsoft.Json;

namespace CountryAPI.Repositories
{
    public class CountryRespoitory : ICountryRespoitory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        HttpClient _client = new();

        public CountryRespoitory(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        public async Task<List<Country>> GetAllAsync()
        {
            _client = _httpClientFactory.CreateClient("CountryApi");

            var httpresponse = await _client.GetAsync("all");

            if (!httpresponse.IsSuccessStatusCode)
                return [];

            string responseData = await httpresponse.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<List<CountryEntity>>(responseData);


            
            return response?.Select( x => new Country
            {
                Name =x.Name.Common,
                Flag = x.Flags.Png ?? string.Empty,
            }).ToList() ?? [];
        }


        public async Task<CountryDetails> GetByNameAsync(string name)
        {
            _client = _httpClientFactory.CreateClient("CountryApi");

            var httpresponse = await _client.GetAsync("all");

            if (!httpresponse.IsSuccessStatusCode)
                return new CountryDetails();

            string responseData = await httpresponse.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<List<CountryEntity>>(responseData);



            return response?.Select(x => new CountryDetails
            {
                Name = x.Name?.Common ?? string.Empty,
                Capital = x.Capital?.FirstOrDefault() ?? string.Empty,
                Flag = x.Flags.Png ?? string.Empty,
                Population = x.Population
            }).Where(x =>x.Name.Equals(name)).FirstOrDefault() ?? new CountryDetails();

        }


    }
}
