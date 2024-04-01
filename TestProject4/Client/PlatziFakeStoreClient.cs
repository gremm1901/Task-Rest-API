namespace AutotestAPI
{
    public class PlatziFakeStoreClient
    {
        RestClient _client;
        public PlatziFakeStoreClient(string url)
        {
            _client = new RestClient(url);
        }
        /// <summary>
        /// Получить список клиентов
        /// </summary>
        /// <param name="limit">лимит вывода массива</param>
        /// <returns></returns>
        public RestResponse<List<UserPFSResponse>> GetUsersPFS(int limit) 
        {
            var req = new RestRequest($"api/v1/users?limit={limit}", Method.Get);
            return _client.Execute<List<UserPFSResponse>>(req);
        }
        /// <summary>
        /// Создать клиента
        /// </summary>
        /// <param name="body">Данные клиента</param>
        /// <returns></returns>
        public RestResponse<UserPFSResponse> CreateUsersPFS(CreateUserPFSRequest body)
        {
            var req = new RestRequest("api/v1/users", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<UserPFSResponse>(req);
        }
        /// <summary>
        /// Получить клиента по его Id
        /// </summary>
        /// <param name="id">Id клиента</param>
        /// <returns></returns>
        public RestResponse<UserPFSResponse> GetUsersIdPFS(int id)
        {
            var req = new RestRequest($"api/v1/users/{id}", Method.Get);
            return _client.Execute<UserPFSResponse>(req);
        }
        /// <summary>
        /// Обновить клиента
        /// </summary>
        /// <param name="body">Данные клиента для обновления</param>
        /// <param name="id">Id клиента</param>
        /// <returns></returns>
        public RestResponse<UserPFSResponse> PutUserIdPFS(CreateUserPFSRequest body, int id)
        {
            var req = new RestRequest($"api/v1/users/{id}", Method.Put);
            req.AddJsonBody(body);
            return _client.Execute<UserPFSResponse>(req);
        }
        /// <summary>
        /// Удалить конкретного клиента
        /// </summary>
        /// <param name="id">Id клиента</param>
        /// <returns></returns>
        public RestResponse<UserPFSResponse> DeleteUsersIdPFS(int id)
        {
            var req = new RestRequest($"api/v1/users/{id}", Method.Delete);
            return _client.Execute<UserPFSResponse>(req);
        }
        /// <summary>
        /// Проверить онлан ли клиент
        /// </summary>
        /// <param name="body">Почта клиента</param>
        /// <returns></returns>
        public RestResponse<IsAvailableUserPFSReaponse> IsAvailableUserPFS(IsAvailableUserPFSRequest body)
        {
            var req = new RestRequest("api/v1/users/is-available", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<IsAvailableUserPFSReaponse>(req);
        }
        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="body">Данные клиента для входа</param>
        /// <returns></returns>
        public RestResponse<LoginUserPFSResponse> LoginUserPFS(LoginUserPFSRequest body)
        {
            var req = new RestRequest("api/v1/auth/login", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<LoginUserPFSResponse>(req);
        }
        /// <summary>
        /// Получить профиль авторизованого клиента
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public RestResponse<UserPFSResponse> GetProfileUserPFS(string token) 
        {
            var req = new RestRequest("api/v1/auth/profile", Method.Get);
            req.AddHeader("Authorization", "Bearer " + token);
            return _client.Execute<UserPFSResponse>(req) ;
        }
        /// <summary>
        /// Получить список продуктов
        /// </summary>
        /// <param name="limit">Лимит по списку</param>
        /// <param name="offset">хз</param>
        /// <returns></returns>
        public RestResponse<List<AllDataProductsPFSResponse>> GetProductPFS(int limit, int offset = 0)
        {
            var req = new RestRequest($"api/v1/products?limit={limit}&offset={offset}", Method.Get);
            return _client.Execute<List<AllDataProductsPFSResponse>>(req);
        }
        /// <summary>
        /// Создать продукт
        /// </summary>
        /// <param name="body">Данные продукта</param>
        /// <returns></returns>
        public RestResponse<CreateProductPFSRequest> CreateProductPFS(CreateUserPFSRequest body)
        {
            var req = new RestRequest("api/v1/products", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<CreateProductPFSRequest>(req);
        }
        /// <summary>
        /// Получить продукт по его id
        /// </summary>
        /// <param name="id">Id продукта</param>
        /// <returns></returns>
        public RestResponse<AllDataProductsPFSResponse> GetProductIdPFS(int id)
        {
            var req = new RestRequest($"api/v1/products/{id}", Method.Get);
            return _client.Execute<AllDataProductsPFSResponse>(req);
        }
        /// <summary>
        /// Обновить конкретный продукт
        /// </summary>
        /// <param name="body">Данные для обновления</param>
        /// <param name="id">Id продукта</param>
        /// <returns></returns>
        public RestResponse<AllDataProductsPFSResponse> PutProductIdPFS(CreateProductPFSRequest body, int id)
        {
            var req = new RestRequest($"api/v1/products/{id}", Method.Put);
            req.AddJsonBody(body);
            return _client.Execute<AllDataProductsPFSResponse>(req);
        }
        /// <summary>
        /// Удалить конкретный продукт
        /// </summary>
        /// <param name="id">Id продукта</param>
        /// <returns></returns>
        public RestResponse DeleteProductIdPFS(int id)
        {
            var req = new RestRequest($"api/v1/products/{id}", Method.Delete);
            return _client.Execute(req);
        }
        /// <summary>
        /// Получить список категорий
        /// </summary>
        /// <param name="limit">Лимит по выводу</param>
        /// <returns></returns>
        public RestResponse<List<CategoriesPFSResponse>> GetCategoriesPFS(int limit)
        {
            var req = new RestRequest($"api/v1/categories?limit={limit}", Method.Get);
            return _client.Execute<List<CategoriesPFSResponse>>(req);
        }
        /// <summary>
        /// Создание новой  котегории
        /// </summary>
        /// <param name="body">Данные категории для создания</param>
        /// <returns></returns>
        public RestResponse<CategoriesPFSResponse> CreateCategoriesPFS(CreateCategoriesPFSRequest body)
        {
            var req = new RestRequest("api/v1/categories", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<CategoriesPFSResponse>(req);
        }
        /// <summary>
        /// Получить категорию по его id
        /// </summary>
        /// <param name="id">id категории</param>
        /// <returns></returns>
        public RestResponse<CategoriesPFSResponse> GetCategoriesIdPFS(int id)
        {
            var req = new RestRequest($"api/v1/categories/{id}", Method.Get);
            return _client.Execute<CategoriesPFSResponse>(req);
        }
        /// <summary>
        /// Обнавить категорию
        /// </summary>
        /// <param name="body">Данные для обновления</param>
        /// <param name="id">Id категории</param>
        /// <returns></returns>
        public RestResponse<CategoriesPFSResponse> PutCategoriesIdPFS(CreateCategoriesPFSRequest body, int id)
        {
            var req = new RestRequest($"api/v1/categories/{id}", Method.Put);
            req.AddJsonBody(body);
            return _client.Execute<CategoriesPFSResponse>(req);
        }
        /// <summary>
        /// Удаление конкретной категории
        /// </summary>
        /// <param name="id">Id категории</param>
        /// <returns></returns>
        public RestResponse<ErrorPFSRespose> DeleteCategoriesIdPFS(int id)
        {
            var req = new RestRequest($"api/v1/categories/{id}", Method.Delete);
            return _client.Execute<ErrorPFSRespose>(req);
        }
    }
}
