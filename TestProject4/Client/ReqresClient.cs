namespace TestProject4
{
    public class ReqresClient
    {
        RestClient _client;
        public ReqresClient(string url)
        {
            _client = new RestClient(url);
        }
        /// <summary>
        /// Создать нового клиента
        /// </summary>
        /// <param name="body">Тело запроса</param>
        /// <returns></returns>
        public RestResponse<CreatedClientResponse> CreateClient(CreateClientRequest body)
        {
            var req = new RestRequest("api/users", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<CreatedClientResponse>(req);
        }
        /// <summary>
        /// Получить список клиентов
        /// </summary>
        /// <param name="page">номер страницы</param>
        /// <param name="per_page">номер подстраницы</param>
        /// <returns></returns>
        public RestResponse<BasicInformationResponse> GetClientPage(int page, int per_page = 0)
        {
            var req = new RestRequest($"api/users?page={page}&per_page={per_page}", Method.Get);
            return _client.Execute<BasicInformationResponse>(req);
        }
        /// <summary>
        /// Получить список resource
        /// </summary>
        /// <param name="page">Номер страницы</param>
        /// <param name="per_page">Номер подстраницы</param>
        /// <returns></returns>
        public RestResponse<ResourceListResponse> GetResourcePage(int page, int per_page = 0)
        {
            var req = new RestRequest("api/{resource}" + $"?page={page}&per_page={per_page}", Method.Get);
            return _client.Execute<ResourceListResponse>(req);
        }
        /// <summary>
        /// Получить клиента по его номеру
        /// </summary>
        /// <param name="id">Номер клиента</param>
        /// <returns></returns>
        public RestResponse<UserIdResponse> GetClientId(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Get);
            return _client.Execute<UserIdResponse>(req);
        }
        /// <summary>
        /// Полное изменение клиента
        /// </summary>
        /// <param name="id">Номер клиента</param>
        /// <returns></returns>
        public RestResponse<UpdatedAtResponse> PutUpdateClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Put);
            return _client.Execute<UpdatedAtResponse>(req);
        }
        /// <summary>
        /// Частичное изменение клиента
        /// </summary>
        /// <param name="id">Номер клиента</param>
        /// <returns></returns>
        public RestResponse<UpdatedAtResponse> PutchUpdateClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Patch);
            return _client.Execute<UpdatedAtResponse>(req);
        }
        /// <summary>
        /// Удаление клиента
        /// </summary>
        /// <param name="id">Номер клиента</param>
        /// <returns></returns>
        public RestResponse DeleteClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Delete);
            return _client.Execute(req);
        }
        /// <summary>
        /// Получение неизвестного resource по id
        /// </summary>
        /// <param name="id">номер resource</param>
        /// <returns></returns>
        public RestResponse<ResourseIdResponse> GetResourcePage(int id)
        {
            var req = new RestRequest("api/{resource}" + $"{id}", Method.Get);
            return _client.Execute<ResourseIdResponse>(req);
        }
        /// <summary>
        /// Полное изменение неизвестного resource
        /// </summary>
        /// <param name="id">номер resource</param>
        /// <returns></returns>
        public RestResponse<UpdatedAtResponse> PutUpdateResourceList(int id)
        {
            var req = new RestRequest("api/{resource}" + $"{id}", Method.Put);
            return _client.Execute<UpdatedAtResponse>(req);
        }
        /// <summary>
        /// Частичное изменение неизвестного resource
        /// </summary>
        /// <param name="id">номер resource</param>
        /// <returns></returns>
        public RestResponse<UpdatedAtResponse> PutchUpdateResourceList(int id)
        {
            var req = new RestRequest("api/{resource}" + $"{id}", Method.Patch);
            return _client.Execute<UpdatedAtResponse>(req);
        }
        /// <summary>
        /// Удалить неизвестный resource
        /// </summary>
        /// <param name="id">номер resource</param>
        /// <returns></returns>
        public RestResponse DeleteResourceList(int id)
        {
            var req = new RestRequest("api/{resource}" + $"{id}", Method.Delete);
            return _client.Execute(req);
        }
        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="body">Данные клиента для авторизации</param>
        /// <returns></returns>
        public RestResponse<LoginClientResponse> CreateSessionClient(LoginRequest body)
        {
            var req = new RestRequest("api/login", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<LoginClientResponse>(req);
        }
        /// <summary>
        /// Создание нового клиента
        /// </summary>
        /// <param name="body">Данные клиента для регистрации</param>
        /// <returns></returns>
        public RestResponse<RegisterClientResponse> RegisterClient(RegisterRequest body)
        {
            var req = new RestRequest("api/register", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<RegisterClientResponse>(req);
        }
        /// <summary>
        /// Разлогиниться из под клиента
        /// </summary>
        /// <returns></returns>
        public RestResponse LogoutClient()
        {
            var req = new RestRequest("api/logout", Method.Post);
            return _client.Execute(req);
        }
    }
}
