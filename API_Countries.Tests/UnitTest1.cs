using API_Countries.Models;

namespace API_Countries.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Country_Code()
        {
            Country country = new();

            country.CountryCode = "FR";

            Assert.AreEqual("FR", country.CountryCode);
        }

        [TestMethod]
        public void Test_Country_Code_Length() 
        {
            Country country = new();
            country.CountryCode = "FR";
            Assert.AreEqual(2, country.CountryCode.Length);
        }
    }
}