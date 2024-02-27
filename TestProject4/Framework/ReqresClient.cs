namespace TestProject4
{
    public class ReqresClient
    {
        RestClient _client;
        public ReqresClient(string url)
        {
            _client = new RestClient(url);
        }

        public RestResponse CreateClient(object body)
        {
            var req = new RestRequest("api/users", Method.Post);
            req.AddBody(body);
            return _client.Execute(req);
        }

        public RestResponse GetClientPage(int page, int per_page = 0, int status = 200)
        {
            var req = new RestRequest($"api/users?page={page}&per_page={per_page}", Method.Get);
            return _client.Execute(req);
        }

        public RestResponse PutUpdateClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Put);
            return _client.Execute(req);
        }

        public RestResponse PutchUpdateClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Patch);
            return _client.Execute(req);
        }

        public RestResponse DeleteClient(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Delete);
            return _client.Execute(req);
        }

        public RestResponse GetClientId(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Get);
            return _client.Execute(req);
        }



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
