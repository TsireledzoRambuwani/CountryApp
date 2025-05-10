

using CountryAPI.Models;
using CountryAPI.Repositories.Interface;

namespace xunit.Tests.Infrastructure.Repositories
{
    public class MockCountryRespoitoryThrowsGenericException : ICountryRespoitory
    {
        public Task<List<Country>> GetAllAsync()
        {
            throw new NotImplementedException("GetAllAsync has an exception");
        }

        public Task<CountryDetails> GetByNameAsync(string name)
        {
            throw new NotImplementedException("GetByNameAsync has an exception");
        }
    }
}
