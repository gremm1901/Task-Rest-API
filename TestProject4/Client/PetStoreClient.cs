namespace AutotestAPI
{
    internal class PetStoreClient
    {
        RestClient _client;
        public PetStoreClient(string url)
        {
            _client = new RestClient(url);
        }
        /// <summary>
        /// Создание нескольких клиентов
        /// </summary>
        /// <param name="body">Данные клиента</param>
        /// <returns></returns>
        public RestResponse<AnswerResponse> CreateWithListUser(IEnumerable<CreateUserRequest> body) {
            var req = new RestRequest("v2/user/createWithList", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<AnswerResponse>(req);
        }
        /// <summary>
        /// Создание клиекнта
        /// </summary>
        /// <param name="body">Данные клиента</param>
        /// <returns></returns>
        public RestResponse<AnswerResponse> CreateUser(CreateUserRequest body)
        {
            var req = new RestRequest("v2/user", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<AnswerResponse>(req);
        }
        /// <summary>
        /// Найти клиента по его username
        /// </summary>
        /// <param name="username">username клиента</param>
        /// <returns></returns>
        public RestResponse<UserResponse> GetUserPetStore(string username) {
            var req = new RestRequest($"v2/user/{username}", Method.Get);
            return _client.Execute<UserResponse>(req);
        }
        /// <summary>
        /// Найти клиента по его username
        /// </summary>
        /// <param name="username">username клиента</param>
        /// <returns></returns>
        public RestResponse<AnswerResponse> DeleteUserPetStore(string username)
        {
            var req = new RestRequest($"v2/user/{username}", Method.Delete);
            return _client.Execute<AnswerResponse>(req);
        }
        /// <summary>
        /// Вернуть список питомцев по их статусу "available","pending","sold"
        /// </summary>
        /// <param name="status">статусу "available","pending","sold"</param>
        /// <returns></returns>
        public RestResponse<List<PetResponse>> GetPetFindByStatus(string status)
        {
                var req = new RestRequest($"/v2/pet/findByStatus?status={status}", Method.Get);
                return _client.Execute<List<PetResponse>>(req);
        }
        /// <summary>
        /// Получить питомца по его id
        /// </summary>
        /// <param name="id">id питомца</param>
        /// <returns></returns>
        public RestResponse<PetResponse> GetPetId(long id) 
        {
            var req = new RestRequest($"v2/pet/{id}", Method.Get);
            return _client.Execute<PetResponse>(req);
        }
    }
}
