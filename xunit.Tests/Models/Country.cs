using AutoFixture.Xunit2;

namespace xunit.Tests.Models
{
    public class Country
    {
        [Theory, AutoData]
        public void ItSetsPropertyName(string name, CountryAPI.Models.Country model)
        {
            model.Name = name;
            Assert.Equal(name, model.Name);
        }
        [Theory, AutoData]
        public void ItSetsPropertyFlag(string flag, CountryAPI.Models.Country model)
        {
            model.Flag = flag;
            Assert.Equal(flag, model.Flag);
        }
    }
}
