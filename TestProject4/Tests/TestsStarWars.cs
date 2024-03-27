namespace AutotestAPI
{
    public class TestsStarWars
    {

        //ֲûחמג לועמהא GetPeoplePage
        [Test]
        public void TestGetPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPeoplePageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllPeoplePage
        [Test]
        public void TestAllPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPeoplePageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetFilmsPage
        [Test]
        public void TestGetFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetFilmsPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllFilmsPage
        [Test]
        public void TestAllFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllFilmsPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetVehiclesPage
        [Test]
        public void TestVehiclesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetVehiclesPageSW(2);
            AssertionHelper.ChecksStatus(resp, 404);
        }
        //ֲûחמג לועמהא GetAllVehiclesPage
        [Test]
        public void TestAllVehiclesPag()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllVehiclesPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetStarshipsPage
        [Test]
        public void TestStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetStarshipsPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllGetStarshipsPage
        [Test]
        public void TestAllStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllStarshipsPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetPlanetPage
        [Test]
        public void TestPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPlanetPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא AllGetPlanetPage
        [Test]
        public void TestAllPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPlanetPageSW();
            AssertionHelper.ChecksStatus(resp);
        }

        //ֲûחמג לועמהא GetSpeciesPage
        [Test]
        public void TestSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetSpeciesPageSW(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //ֲûחמג לועמהא GetAllSpeciesPage
        [Test]
        public void TestAllSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllSpeciesPageSW();
            AssertionHelper.ChecksStatus(resp);
        }
    }
}