namespace AutotestAPI
{
    public class TestsStarWars
    {

        //����� ������ GetPeoplePage
        [Test]
        public void TestGetPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPeoplePageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllPeoplePage
        [Test]
        public void TestAllPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPeoplePageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetFilmsPage
        [Test]
        public void TestGetFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetFilmsPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllFilmsPage
        [Test]
        public void TestAllFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllFilmsPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetVehiclesPage
        [Test]
        public void TestVehiclesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetVehiclesPageSW(2);
            AssertionHelper.ChecksStatus(resp, 404);
        }
        //����� ������ GetAllVehiclesPage
        [Test]
        public void TestAllVehiclesPag()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllVehiclesPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetStarshipsPage
        [Test]
        public void TestStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetStarshipsPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllGetStarshipsPage
        [Test]
        public void TestAllStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllStarshipsPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetPlanetPage
        [Test]
        public void TestPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPlanetPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ AllGetPlanetPage
        [Test]
        public void TestAllPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPlanetPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //����� ������ GetSpeciesPage
        [Test]
        public void TestSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetSpeciesPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //����� ������ GetAllSpeciesPage
        [Test]
        public void TestAllSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllSpeciesPageSW();
            AssertionHelper.ChecksStatus(resp);
        }
    }
}