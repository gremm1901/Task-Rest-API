using AutotestAPI.Client;
using AssertionHelper = AutotestAPI.Framework.AssertionHelper;
using EnumHelper = AutotestAPI.Framework.EnumHelper;
using static AutotestAPI.Enums.DomenEnum;

namespace AutotestAPI.Tests
{
    public class TestsStarWars
    {

        //ֲûחמג לועמהא GetPeoplePage
        [Test]
        public void TestGetPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPeoplePage(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllPeoplePage
        [Test]
        public void TestAllPeoplePage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetAllPeoplePage();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetFilmsPage
        [Test]
        public void TestGetFilmsPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetFilmsPage(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllFilmsPage
        [Test]
        public void TestAllFilmsPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetAllFilmsPage();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetVehiclesPage
        [Test]
        public void TestVehiclesPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetVehiclesPage(2);
            AssertionHelper.ChecksStatus(resp, 404);
        }
        //ֲûחמג לועמהא GetAllVehiclesPage
        [Test]
        public void TestAllVehiclesPag()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetAllVehiclesPage();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetStarshipsPage
        [Test]
        public void TestStarshipsPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetStarshipsPage(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllGetStarshipsPage
        [Test]
        public void TestAllStarshipsPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetAllStarshipsPage();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetPlanetPage
        [Test]
        public void TestPlanetPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetPlanetPage(2);
            Framework.AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllGetPlanetPage
        [Test]
        public void TestAllPlanetPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetAllPlanetPage();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetSpeciesPage
        [Test]
        public void TestSpeciesPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetSpeciesPage(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא GetAllSpeciesPage
        [Test]
        public void TestAllSpeciesPage()
        {
            var client = new StarWarsClient(EnumHelper.GetDescription(StarWars));
            var resp = client.GetAllSpeciesPage();
            AssertionHelper.ChecksStatus(resp);
        }
    }
}