//start test
namespace TestProject4
{
    public class TestsStarWars
    {
        //������� 1
        [Test]
        public void TestFilmsPeopleStarWars()
        {
            var request = new StarWarsClient("https://swapi.dev");
            var resp = request.GetPeoplePage(2);

            if (resp.Data.Films.Length != 0 && CheckStatus.CheckStatusBool(resp))
            {
                for (int i = 0; i < resp.Data.Films.Length; i++)
                {
                    Console.WriteLine(resp.Data.Films[i]);
                }
                CheckStatus.ChecksStatus(resp);
            }
        }
        //������� 1
        [Test]
        public void TestFilmsStarshipsStarWars()
        {
            var request = new StarWarsClient("https://swapi.dev");
            var resp = request.GetStarshipsPage(2);
            if (resp.Data.Films.Length != 0 && CheckStatus.CheckStatusBool(resp))
            {
                for (int i = 0; i < resp.Data.Films.Length; i++)
                {
                    Console.WriteLine(resp.Data.Films[i]);
                }
                CheckStatus.ChecksStatus(resp);
            }
        }
        //������� 1
        [Test]
        public void TestFilmsPlanetStarWars()
        {
            var request = new StarWarsClient("https://swapi.dev");
            var resp = request.GetPlanetPage(2);
            if (resp.Data.Films.Length != 0 && CheckStatus.CheckStatusBool(resp))
            {
                for (int i = 0; i < resp.Data.Films.Length; i++)
                {
                    Console.WriteLine(resp.Data.Films[i]);
                }
                CheckStatus.ChecksStatus(resp);
            }
        }
    }
}