namespace AutotestAPI
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
        public RestResponse<PeopleResponse> GetPeoplePageSW(int id)
        {
            var req = new RestRequest($"api/people/{id}/", Method.Get);
            return _client.Execute<PeopleResponse>(req);
        }
        /// <summary>
        /// Получить список всех героев
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllPeopleResponse> GetAllPeoplePageSW()
        {
            var req = new RestRequest("api/people/", Method.Get);
            return _client.Execute<AllPeopleResponse>(req);
        }

        /// <summary>
        /// Получить данные по планте
        /// </summary>
        /// <param name="id">номер планеты</param>
        /// <returns></returns>
        public RestResponse<PlanetResponse> GetPlanetPageSW(int id)
        {
            var req = new RestRequest($"api/planets/{id}/", Method.Get);
            return _client.Execute<PlanetResponse>(req);
        }
        /// <summary>
        /// Получить список всех планет
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllPlanetResponse> GetAllPlanetPageSW()
        {
            var req = new RestRequest("api/planets/", Method.Get);
            return _client.Execute<AllPlanetResponse>(req);
        }

        /// <summary>
        /// Получить данные по звездолеты
        /// </summary>
        /// <param name="id">номер звездолетыа</param>
        /// <returns></returns>
        public RestResponse<StarshipsResponse> GetStarshipsPageSW(int id)
        {
            var req = new RestRequest($"api/starships/{id}/", Method.Get);
            return _client.Execute<StarshipsResponse>(req);
        }
        /// <summary>
        /// Получить список всех звездолетов
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllStarshipsResponse> GetAllStarshipsPageSW()
        {
            var req = new RestRequest("api/starships/", Method.Get);
            return _client.Execute<AllStarshipsResponse>(req);
        }

        /// <summary>
        /// Получить данные по фильму
        /// </summary>
        /// <param name="id">номер фильма</param>
        /// <returns></returns>
        public RestResponse<FilmsResponse> GetFilmsPageSW(int id)
        {
            var req = new RestRequest($"api/films/{id}/", Method.Get);
            return _client.Execute<FilmsResponse>(req);
        }
        /// <summary>
        /// Получить список всх фильмов
        /// </summary>
        /// <returns></returns>
        public RestResponse<FilmsResponse> GetAllFilmsPageSW()
        {
            var req = new RestRequest("api/films/", Method.Get);
            return _client.Execute<FilmsResponse>(req);
        }

        /// <summary>
        /// Получить данные по транспортным средствам
        /// </summary>
        /// <param name="id">номер транспортного средства</param>
        /// <returns></returns>
        public RestResponse<VehiclesResponse> GetVehiclesPageSW(int id)
        {
            var req = new RestRequest($"api/vehicles/{id}/", Method.Get);
            return _client.Execute<VehiclesResponse>(req);
        }
        /// <summary>
        /// Получить полный список транспортных средств
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllVehiclesResponse> GetAllVehiclesPageSW()
        {
            var req = new RestRequest("api/vehicles/", Method.Get);
            return _client.Execute<AllVehiclesResponse>(req);
        }

        /// <summary>
        /// Получить данные по типу существа
        /// </summary>
        /// <param name="id">номер существа</param>
        /// <returns></returns>
        public RestResponse<SpeciesResponse> GetSpeciesPageSW(int id)
        {
            var req = new RestRequest($"api/species/{id}/", Method.Get);
            return _client.Execute<SpeciesResponse>(req);
        }
        /// <summary>
        /// Получить список всех типов существ
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllSpeciesResponse> GetAllSpeciesPageSW()
        {
            var req = new RestRequest("api/species/", Method.Get);
            return _client.Execute<AllSpeciesResponse>(req);
        }
    }
}