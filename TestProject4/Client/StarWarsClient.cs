namespace TestProject4
{
    public class StarWarsClient
    {
        RestClient _client;
        public StarWarsClient(string url)
        {
            _client = new RestClient(url);
        }
        /// <summary>
        /// Получить данные по герою
        /// </summary>
        /// <param name="id">Номер героя</param>
        /// <returns></returns>
        public RestResponse<PeopleResponse> GetPeoplePage(int id)
        {
            var req = new RestRequest($"api/people/{id}/", Method.Get);
            return _client.Execute<PeopleResponse>(req);
        }
        /// <summary>
        /// Получить данные по планте
        /// </summary>
        /// <param name="id">номер планеты</param>
        /// <returns></returns>
        public RestResponse<PlanetResponse> GetPlanetPage(int id)
        {
            var req = new RestRequest($"api/planets/{id}/", Method.Get);
            return _client.Execute<PlanetResponse>(req);
        }
        /// <summary>
        /// Получить данные по звездолеты
        /// </summary>
        /// <param name="id">номер звездолетыа</param>
        /// <returns></returns>
        public RestResponse<StarshipsResponse> GetStarshipsPage(int id)
        {
            var req = new RestRequest($"api/starships/{id}/", Method.Get);
            return _client.Execute<StarshipsResponse>(req);
        }
    }
}
