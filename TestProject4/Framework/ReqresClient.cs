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
        public RestResponse<CreatedClient> CreateClient(CreateClientRequest body)
        {
            var req = new RestRequest("api/users", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<CreatedClient>(req);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="per_page"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public RestResponse GetClientPage(int page, int per_page = 0, int status = 200)
        {
            var req = new RestRequest($"api/users?page={page}&per_page={per_page}", Method.Get);
            return _client.Execute(req);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RestResponse PutUpdateClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Put);
            return _client.Execute(req);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RestResponse PutchUpdateClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Patch);
            return _client.Execute(req);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RestResponse DeleteClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Delete);
            return _client.Execute(req);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RestResponse GetClientId(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Get);
            return _client.Execute(req);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public RestResponse CreateSessionClient(object body)
        {
            var req = new RestRequest("api/login", Method.Post);
            req.AddBody(body);
            return _client.Execute(req);
        }
        public RestResponse RegisterClient(object body)
        {
            var req = new RestRequest("api/register", Method.Post);
            req.AddBody(body);
            return _client.Execute(req);
        }
        public RestResponse LogoutClient(object body)
        {
            var req = new RestRequest("api/logout", Method.Post);
            req.AddBody(body);
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
