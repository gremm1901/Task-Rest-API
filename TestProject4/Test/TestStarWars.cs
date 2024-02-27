//start test
namespace TestProject4
{
    public class TestStarWars
    {
        //Задание 1
        [Test]
        public void TestFilmsPeopleStarWars()
        {
            var request = new StarWarsClient("https://swapi.dev");
            var resp = request.GetPeoplePage(2);

            var People = JsonConvert.DeserializeObject<People>(resp.Content);

            if (People.Films.Length != 0 && request.checkStatusBool(resp))
            {
                for (int i = 0; i < People.Films.Length; i++)
                {
                    Console.WriteLine(People.Films[i]);
                }
                request.checkStatus(resp);
            }
        }
        //Задание 1
        [Test]
        public void TestFilmsStarshipsStarWars()
        {
            var request = new StarWarsClient("https://swapi.dev");
            var resp = request.GetStarshipsPage(2);

            var starShips = JsonConvert.DeserializeObject<Starships>(resp.Content);

            if (starShips.Films.Length != 0 && request.checkStatusBool(resp))
            {
                for (int i = 0; i < starShips.Films.Length; i++)
                {
                    Console.WriteLine(starShips.Films[i]);
                }
                request.checkStatus(resp);
            }
        }
        //Задание 1
        [Test]
        public void TestFilmsPlanetStarWars()
        {
            var request = new StarWarsClient("https://swapi.dev");
            var resp = request.GetPlanetPage(2);

            var planet = JsonConvert.DeserializeObject<Planet>(resp.Content);

            if (planet.Films.Length != 0 && request.checkStatusBool(resp))
            {
                for (int i = 0; i < planet.Films.Length; i++)
                {
                    Console.WriteLine(planet.Films[i]);
                }
                request.checkStatus(resp);
            }
        }
    }
}
