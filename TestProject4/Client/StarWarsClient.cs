using AutotestAPI.Entities.StarWars.Responses;

namespace AutotestAPI.Client
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
        /// Получить список всех героев
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllPeopleResponse> GetAllPeoplePage()
        {
            var req = new RestRequest("api/people/", Method.Get);
            return _client.Execute<AllPeopleResponse>(req);
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
        /// Получить список всех планет
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllPlanetResponse> GetAllPlanetPage()
        {
            var req = new RestRequest("api/planets/", Method.Get);
            return _client.Execute<AllPlanetResponse>(req);
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
        /// <summary>
        /// Получить список всех звездолетов
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllStarshipsResponse> GetAllStarshipsPage()
        {
            var req = new RestRequest("api/starships/", Method.Get);
            return _client.Execute<AllStarshipsResponse>(req);
        }

        /// <summary>
        /// Получить данные по фильму
        /// </summary>
        /// <param name="id">номер фильма</param>
        /// <returns></returns>
        public RestResponse<FilmsResponse> GetFilmsPage(int id)
        {
            var req = new RestRequest($"api/films/{id}/", Method.Get);
            return _client.Execute<FilmsResponse>(req);
        }
        /// <summary>
        /// Получить список всх фильмов
        /// </summary>
        /// <returns></returns>
        public RestResponse<FilmsResponse> GetAllFilmsPage()
        {
            var req = new RestRequest("api/films/", Method.Get);
            return _client.Execute<FilmsResponse>(req);
        }

        /// <summary>
        /// Получить данные по транспортным средствам
        /// </summary>
        /// <param name="id">номер транспортного средства</param>
        /// <returns></returns>
        public RestResponse<VehiclesResponse> GetVehiclesPage(int id)
        {
            var req = new RestRequest($"api/vehicles/{id}/", Method.Get);
            return _client.Execute<VehiclesResponse>(req);
        }
        /// <summary>
        /// Получить полный список транспортных средств
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllVehiclesResponse> GetAllVehiclesPage()
        {
            var req = new RestRequest("api/vehicles/", Method.Get);
            return _client.Execute<AllVehiclesResponse>(req);
        }

        /// <summary>
        /// Получить данные по типу существа
        /// </summary>
        /// <param name="id">номер существа</param>
        /// <returns></returns>
        public RestResponse<SpeciesResponse> GetSpeciesPage(int id)
        {
            var req = new RestRequest($"api/species/{id}/", Method.Get);
            return _client.Execute<SpeciesResponse>(req);
        }
        /// <summary>
        /// Получить список всех типов существ
        /// </summary>
        /// <returns></returns>
        public RestResponse<AllSpeciesResponse> GetAllSpeciesPage()
        {
            var req = new RestRequest("api/species/", Method.Get);
            return _client.Execute<AllSpeciesResponse>(req);
        }
    }
}