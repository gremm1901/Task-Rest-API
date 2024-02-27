namespace TestProject4
{
    public class StarWarsClient
    {
        RestClient _client;
        public StarWarsClient(string url)
        {
            _client = new RestClient(url);
        }

        public RestResponse GetPeoplePage(int page)
        {
            var req = new RestRequest($"api/people/{page}/", Method.Get);
            return _client.Execute(req);
        }

        public RestResponse GetPlanetPage(int page)
        {
            var req = new RestRequest($"api/planets/{page}/", Method.Get);
            return _client.Execute(req);
        }

        public RestResponse GetStarshipsPage(int page)
        {
            var req = new RestRequest($"api/starships/{page}/", Method.Get);
            return _client.Execute(req);
        }

        public bool checkStatusBool(RestResponse requst, int status = 200)
        {
            bool check = (int)requst.StatusCode == status ? true : false;
            return check;
        }

        public void checkStatus(RestResponse requst, int status = 200)
        {

            Assert.IsTrue((int)requst.StatusCode == status, $"Статус код не соответствует {status}");
        }
    }
}
