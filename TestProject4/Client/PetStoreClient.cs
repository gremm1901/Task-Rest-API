namespace AutotestAPI
{
    public class PetStoreClient
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
        public RestResponse<AnswerPSResponse> CreateWithListUserPS(IEnumerable<CreateUserPSRequest> body) {
            var req = new RestRequest("v2/user/createWithList", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<AnswerPSResponse>(req);
        }
        /// <summary>
        /// Создание клиекнта
        /// </summary>
        /// <param name="body">Данные клиента</param>
        /// <returns></returns>
        public RestResponse<AnswerPSResponse> CreateUserPS(CreateUserPSRequest body)
        {
            var req = new RestRequest("v2/user", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<AnswerPSResponse>(req);
        }
        /// <summary>
        /// Найти клиента по его username
        /// </summary>
        /// <param name="username">username клиента</param>
        /// <returns></returns>
        public RestResponse<UserPSResponse> GetUserPS(string username) {
            var req = new RestRequest($"v2/user/{username}", Method.Get);
            return _client.Execute<UserPSResponse>(req);
        }
        /// <summary>
        /// Найти клиента по его username
        /// </summary>
        /// <param name="username">username клиента</param>
        /// <returns></returns>
        public RestResponse<AnswerPSResponse> DeleteUserPS(string username)
        {
            var req = new RestRequest($"v2/user/{username}", Method.Delete);
            return _client.Execute<AnswerPSResponse>(req);
        }
        /// <summary>
        /// Вернуть список питомцев по их статусу "available","pending","sold"
        /// </summary>
        /// <param name="status">статусу "available","pending","sold"</param>
        /// <returns></returns>
        public RestResponse<List<PetPSResponse>> GetPetFindByStatusPS(string status)
        {
                var req = new RestRequest($"/v2/pet/findByStatus?status={status}", Method.Get);
                return _client.Execute<List<PetPSResponse>>(req);
        }
        /// <summary>
        /// Получить питомца по его id
        /// </summary>
        /// <param name="id">id питомца</param>
        /// <returns></returns>
        public RestResponse<PetPSResponse> GetPetIdPS(long id) 
        {
            var req = new RestRequest($"v2/pet/{id}", Method.Get);
            return _client.Execute<PetPSResponse>(req);
        }
    }
}
