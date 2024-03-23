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
        /// Создание клиекнта
        /// </summary>
        /// <param name="body">Данные клиента</param>
        /// <returns></returns>
        public RestResponse<AnswerResponse> CreateWithListUser(List<CreateUserRequest> body) {
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
    }
}
