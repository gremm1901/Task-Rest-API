using AutotestAPI.Client;

namespace AutotestAPI.Tests
{
    public class TestsStarWars
    {

        //����� ������ GetPeoplePage
        [Test]
        public void TestGetPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPeoplePage(2);
            Framework.AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllPeoplePage
        [Test]
        public void TestAllPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPeoplePage();
            Framework.AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetFilmsPage
        [Test]
        public void TestGetFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetFilmsPage(2);
            Framework.AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllFilmsPage
        [Test]
        public void TestAllFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllFilmsPage();
            Framework.AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetVehiclesPage
        [Test]
        public void TestVehiclesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetVehiclesPage(2);
            Framework.AssertionHelper.ChecksStatus(resp, 404);
        }
        //����� ������ GetAllVehiclesPage
        [Test]
        public void TestAllVehiclesPag()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllVehiclesPage();
            Framework.AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetStarshipsPage
        [Test]
        public void TestStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetStarshipsPage(2);
            Framework.AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllGetStarshipsPage
        [Test]
        public void TestAllStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllStarshipsPage();
            Framework.AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetPlanetPage
        [Test]
        public void TestPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPlanetPage(2);
            Framework.AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllGetPlanetPage
        [Test]
        public void TestAllPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPlanetPage();
            Framework.AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetSpeciesPage
        [Test]
        public void TestSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetSpeciesPage(2);
            Framework.AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ GetAllSpeciesPage
        [Test]
        public void TestAllSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllSpeciesPage();
            Framework.AssertionHelper.ChecksStatus(resp);
        }
    }
}