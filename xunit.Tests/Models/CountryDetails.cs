using AutoFixture.Xunit2;
using Xunit;

namespace xunit.Tests.Models
{
    public class CountryDetails
    {
        [Theory, AutoData]
        public void ItSetsPropertyName(string name, CountryAPI.Models.CountryDetails model)
        {
            model.Name = name;
            Assert.Equal(name, model.Name);
        }
        [Theory, AutoData]
        public void ItSetsPropertyFlag(string flag, CountryAPI.Models.CountryDetails model)
        {
            model.Flag = flag;
            Assert.Equal(flag, model.Flag);
        }

        [Theory, AutoData]
        public void ItSetsPropertyCapital(string capital, CountryAPI.Models.CountryDetails model)
        {
            model.Capital = capital;
            Assert.Equal(capital, model.Name);
        }
        [Theory, AutoData]
        public void ItSetsPropertyPopulation(long population, CountryAPI.Models.CountryDetails model)
        {
            model.Population = population;
            Assert.Equal(population, model.Population);
        }
    }
}
