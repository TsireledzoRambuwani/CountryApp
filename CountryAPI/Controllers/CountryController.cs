using CountryAPI.Models;
using CountryAPI.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;


namespace CountryAPI.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/countries")]
    public class CountryController(ICountryRespoitory countryRespoitory) : ControllerBase
    {
        private readonly ICountryRespoitory _countryRespoitory = countryRespoitory;

        /// <summary>
        /// Retrieve all countries
        /// </summary>
        /// <response code="200">A list of countries</response>
        [HttpGet()]
        public async Task<List<Country>> GetAll()
        {
            try
            {
                return await _countryRespoitory.GetAllAsync();
            }
            catch (Exception ex)
            {

                return null;

            }
        }


        /// <summary>
        /// Retrieve details about a specific country
        /// </summary>
        /// <response code="200">Details about the country</response>
        [HttpGet("{name}")]
        public async Task<CountryDetails> GetDetails(string name)
        {
            try
            {
                return await _countryRespoitory.GetByNameAsync(name);
            }
            catch (Exception ex)
            {

                return null;

            }
        }
    }
}



