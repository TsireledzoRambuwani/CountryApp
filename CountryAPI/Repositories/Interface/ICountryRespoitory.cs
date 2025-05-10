using CountryAPI.Models;

namespace CountryAPI.Repositories.Interface
{
    public interface ICountryRespoitory
    {
        Task<List<Country>> GetAllAsync();
        Task<CountryDetails> GetByNameAsync(string name);
    }
}
