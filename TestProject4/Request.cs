

namespace TestProject4
{
    internal class Request
    {
        public RestResponse getRequest(string url, string resource)
        {
            using var client = new RestClient(url);
            var req = new RestRequest(resource);
            var resp =  client.ExecuteGet(req);
            return resp;
        }
        public RestResponse postRequest(string url, string resource,object body)
        {
            using var client = new RestClient(url);
            var req = new RestRequest(resource);
            req.AddBody(body);
            var resp = client.ExecutePost(req);
            return resp;
        }
        public bool checkStatus(RestResponse requst, int status)
        {
            bool check = (int)requst.StatusCode == status ? true : false;
            return check;
        }
    }
}
