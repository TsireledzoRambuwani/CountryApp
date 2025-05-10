using CountryAPI.Models;
using CountryAPI.Repositories.Interface;

namespace xunit.Tests.Infrastructure.Repositories
{
    public class MockCountryRespoitory : ICountryRespoitory
    {  
        public async Task<List<Country>> GetAllAsync()
        {
            var countries = new List<Country> {
                        new() {
                                Flag ="https://upload.wikimedia.org/wikipedia/commons/a/af/Flag_of_South_Africa.svg",
                                Name = "South Africa"
                            },
                        new() {
                            Flag ="https://upload.wikimedia.org/wikipedia/commons/a/af/Flag_of_South_Africa.svg",
                            Name = "Sa"
                        }
                        };
            return await Task.FromResult(countries);
        }

        public async Task<CountryDetails> GetByNameAsync(string name)
        {
            var country =
                        new CountryDetails
                        {
                            Flag = "https://upload.wikimedia.org/wikipedia/commons/a/af/Flag_of_South_Africa.svg",
                            Name = "South Africa",
                            Capital ="Republic",
                            Population=100
                            
                        };
                        
            return await Task.FromResult(country);
        }
    }
}
