namespace AutotestAPI
{
    public class TestsStarWars
    {

        //Âûחמג לועמהא GetPeoplePage
        [Test]
        public void TestGetPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPeoplePage(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }
        //Âûחמג לועמהא AllPeoplePage
        [Test]
        public void TestAllPeoplePage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPeoplePage();
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }

        //Âûחמג לועמהא GetFilmsPage
        [Test]
        public void TestGetFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetFilmsPage(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }
        //Âûחמג לועמהא AllFilmsPage
        [Test]
        public void TestAllFilmsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllFilmsPage();
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }

        //Âûחמג לועמהא GetVehiclesPage
        [Test]
        public void TestVehiclesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetVehiclesPage(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp, 404);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }
        //Âûחמג לועמהא GetAllVehiclesPage
        [Test]
        public void TestAllVehiclesPag()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllVehiclesPage();
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }

        //Âûחמג לועמהא GetStarshipsPage
        [Test]
        public void TestStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetStarshipsPage(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }
        //Âûחמג לועמהא AllGetStarshipsPage
        [Test]
        public void TestAllStarshipsPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllStarshipsPage();
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }

        //Âûחמג לועמהא GetPlanetPage
        [Test]
        public void TestPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetPlanetPage(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }
        //Âûחמג לועמהא AllGetPlanetPage
        [Test]
        public void TestAllPlanetPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllPlanetPage();
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }

        //Âûחמג לועמהא GetSpeciesPage
        [Test]
        public void TestSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetSpeciesPage(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }
        //Âûחמג לועמהא GetAllSpeciesPage
        [Test]
        public void TestAllSpeciesPage()
        {
            var client = new StarWarsClient("https://swapi.dev");
            var resp = client.GetAllSpeciesPage();
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Ïףסעמי מעגוע"); }
        }
    }
}