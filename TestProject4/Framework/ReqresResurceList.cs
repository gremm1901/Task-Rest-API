namespace TestProject4
{
    public class ReqresResurceList
    {
        RestClient _client;
        public ReqresResurceList(string url)
        {
            _client = new RestClient(url);
        }

        public RestResponse GetResourceList(int page, int per_page = 0)
        {
            var req = new RestRequest("api/{resource}" + $"?page={page}&per_page={per_page}", Method.Get);
            return _client.Execute(req);
        }

        public RestResponse PutUpdateResourceList(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Put);
            return _client.Execute(req);
        }

        public RestResponse PutchUpdateResourceList(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Patch);
            return _client.Execute(req);
        }

        public RestResponse DeleteResourceListt(int id)
        {
            var req = new RestRequest($"api/users/{id}", Method.Delete);
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
