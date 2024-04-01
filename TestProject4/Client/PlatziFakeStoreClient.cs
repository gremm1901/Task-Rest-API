using AutotestAPI.Entities.PlatziFakeStore.Requests;
using AutotestAPI.Entities.PlatziFakeStore.Responses;

namespace AutotestAPI.Client
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
        public RestResponse<List<UserResponse>> GetUsers(int limit)
        {
            var req = new RestRequest($"api/v1/users?limit={limit}", Method.Get);
            return _client.Execute<List<UserResponse>>(req);
        }
        /// <summary>
        /// Создать клиента
        /// </summary>
        /// <param name="body">Данные клиента</param>
        /// <returns></returns>
        public RestResponse<UserResponse> CreateUsers(CreateUserRequest body)
        {
            var req = new RestRequest("api/v1/users", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<UserResponse>(req);
        }
        /// <summary>
        /// Получить клиента по его Id
        /// </summary>
        /// <param name="id">Id клиента</param>
        /// <returns></returns>
        public RestResponse<UserResponse> GetUsersId(int id)
        {
            var req = new RestRequest($"api/v1/users/{id}", Method.Get);
            return _client.Execute<UserResponse>(req);
        }
        /// <summary>
        /// Обновить клиента
        /// </summary>
        /// <param name="body">Данные клиента для обновления</param>
        /// <param name="id">Id клиента</param>
        /// <returns></returns>
        public RestResponse<UserResponse> PutUserId(CreateUserRequest body, int id)
        {
            var req = new RestRequest($"api/v1/users/{id}", Method.Put);
            req.AddJsonBody(body);
            return _client.Execute<UserResponse>(req);
        }
        /// <summary>
        /// Удалить конкретного клиента
        /// </summary>
        /// <param name="id">Id клиента</param>
        /// <returns></returns>
        public RestResponse<UserResponse> DeleteUsersId(int id)
        {
            var req = new RestRequest($"api/v1/users/{id}", Method.Delete);
            return _client.Execute<UserResponse>(req);
        }
        /// <summary>
        /// Проверить онлан ли клиент
        /// </summary>
        /// <param name="body">Почта клиента</param>
        /// <returns></returns>
        public RestResponse<IsAvailableUserReaponse> IsAvailableUser(IsAvailableUserPRequest body)
        {
            var req = new RestRequest("api/v1/users/is-available", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<IsAvailableUserReaponse>(req);
        }
        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="body">Данные клиента для входа</param>
        /// <returns></returns>
        public RestResponse<LoginUserResponse> LoginUser(LoginUserRequest body)
        {
            var req = new RestRequest("api/v1/auth/login", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<LoginUserResponse>(req);
        }
        /// <summary>
        /// Получить профиль авторизованого клиента
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public RestResponse<UserResponse> GetProfileUser(string token)
        {
            var req = new RestRequest("api/v1/auth/profile", Method.Get);
            req.AddHeader("Authorization", "Bearer " + token);
            return _client.Execute<UserResponse>(req);
        }
        /// <summary>
        /// Получить список продуктов
        /// </summary>
        /// <param name="limit">Лимит по списку</param>
        /// <param name="offset">хз</param>
        /// <returns></returns>
        public RestResponse<List<AllDataProductsResponse>> GetProduct(int limit, int offset = 0)
        {
            var req = new RestRequest($"api/v1/products?limit={limit}&offset={offset}", Method.Get);
            return _client.Execute<List<AllDataProductsResponse>>(req);
        }
        /// <summary>
        /// Создать продукт
        /// </summary>
        /// <param name="body">Данные продукта</param>
        /// <returns></returns>
        public RestResponse<CreateProductRequest> CreateProduct(CreateUserRequest body)
        {
            var req = new RestRequest("api/v1/products", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<CreateProductRequest>(req);
        }
        /// <summary>
        /// Получить продукт по его id
        /// </summary>
        /// <param name="id">Id продукта</param>
        /// <returns></returns>
        public RestResponse<AllDataProductsResponse> GetProductId(int id)
        {
            var req = new RestRequest($"api/v1/products/{id}", Method.Get);
            return _client.Execute<AllDataProductsResponse>(req);
        }
        /// <summary>
        /// Обновить конкретный продукт
        /// </summary>
        /// <param name="body">Данные для обновления</param>
        /// <param name="id">Id продукта</param>
        /// <returns></returns>
        public RestResponse<AllDataProductsResponse> PutProductId(CreateProductRequest body, int id)
        {
            var req = new RestRequest($"api/v1/products/{id}", Method.Put);
            req.AddJsonBody(body);
            return _client.Execute<AllDataProductsResponse>(req);
        }
        /// <summary>
        /// Удалить конкретный продукт
        /// </summary>
        /// <param name="id">Id продукта</param>
        /// <returns></returns>
        public RestResponse DeleteProductId(int id)
        {
            var req = new RestRequest($"api/v1/products/{id}", Method.Delete);
            return _client.Execute(req);
        }
        /// <summary>
        /// Получить список категорий
        /// </summary>
        /// <param name="limit">Лимит по выводу</param>
        /// <returns></returns>
        public RestResponse<List<CategoriesResponse>> GetCategories(int limit)
        {
            var req = new RestRequest($"api/v1/categories?limit={limit}", Method.Get);
            return _client.Execute<List<CategoriesResponse>>(req);
        }
        /// <summary>
        /// Создание новой  котегории
        /// </summary>
        /// <param name="body">Данные категории для создания</param>
        /// <returns></returns>
        public RestResponse<CategoriesResponse> CreateCategories(CreateCategoriesRequest body)
        {
            var req = new RestRequest("api/v1/categories", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<CategoriesResponse>(req);
        }
        /// <summary>
        /// Получить категорию по его id
        /// </summary>
        /// <param name="id">id категории</param>
        /// <returns></returns>
        public RestResponse<CategoriesResponse> GetCategoriesId(int id)
        {
            var req = new RestRequest($"api/v1/categories/{id}", Method.Get);
            return _client.Execute<CategoriesResponse>(req);
        }
        /// <summary>
        /// Обнавить категорию
        /// </summary>
        /// <param name="body">Данные для обновления</param>
        /// <param name="id">Id категории</param>
        /// <returns></returns>
        public RestResponse<CategoriesResponse> PutCategoriesId(CreateCategoriesRequest body, int id)
        {
            var req = new RestRequest($"api/v1/categories/{id}", Method.Put);
            req.AddJsonBody(body);
            return _client.Execute<CategoriesResponse>(req);
        }
        /// <summary>
        /// Удаление конкретной категории
        /// </summary>
        /// <param name="id">Id категории</param>
        /// <returns></returns>
        public RestResponse<ErrorRespose> DeleteCategoriesId(int id)
        {
            var req = new RestRequest($"api/v1/categories/{id}", Method.Delete);
            return _client.Execute<ErrorRespose>(req);
        }
    }
}
