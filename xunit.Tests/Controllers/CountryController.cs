

using AutoFixture.Xunit2;
using CountryAPI.Models;
using CountryAPI.Models.Domain;
using System.Net.NetworkInformation;
using xunit.Tests.Infrastructure.Repositories;

namespace xunit.Tests.Controllers
{
    public class CountryController
    {
        [Theory, AutoData]
        public async Task ItGetsAllSuccessfully(
            MockCountryRespoitory countryRespoitory) 
        {
            var controller = new CountryAPI.Controllers.CountryController(
             countryRespoitory);

            var result = await controller
                            .GetAll();

            Assert.IsType<List<Country>>(result);
            Assert.IsAssignableFrom<List<Country>>(result);
            Assert.Equal(2, (result as IEnumerable<Country>)?.ToArray().Length);

        }

        [Theory, AutoData]
        public async Task ItCatchesUnhandledExceptionsInGetsAll(
             MockCountryRespoitoryThrowsGenericException countryRespoitory)
        {
            var controller = new CountryAPI.Controllers.CountryController(
             countryRespoitory);

            var result = await controller
                            .GetAll();

            Assert.Null(null);
        }


        [Theory, AutoData]
        public async Task ItGetDetailsSuccessfully(
            MockCountryRespoitory countryRespoitory)
        {
            var controller = new CountryAPI.Controllers.CountryController(
             countryRespoitory);

            var result = await controller
                            .GetDetails("South Africa");

            Assert.IsType<CountryDetails>(result);
            Assert.IsAssignableFrom<CountryDetails>(result);

        }

        [Theory, AutoData]
        public async Task ItCatchesUnhandledExceptionsInGetDetails(
            string name,
             MockCountryRespoitoryThrowsGenericException countryRespoitory)
        {
            var controller = new CountryAPI.Controllers.CountryController(
             countryRespoitory);
            var result = await controller
                            .GetDetails(name);

            Assert.Null(null);
        }
    }
}
