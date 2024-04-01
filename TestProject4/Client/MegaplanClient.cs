using AutotestAPI.Entities.Megaplan.Requests;
using AutotestAPI.Entities.Megaplan.Responses;

namespace AutotestAPI.Client
{
    public class MegaplanClient
    {
        RestClient _client;
        public MegaplanClient(string url)
        {
            _client = new RestClient(url);
        }
        public RestResponse<AccessTokenResponse> AuthEmployee(AuthEmployeeRequest body)
        {
            var req = new RestRequest("api/v3/auth/access_token", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<AccessTokenResponse>(req);
        }
        public RestResponse<RootTaskMPResponse> CreateTask(TaskCreateRequest body, string token)
        {
            var req = new RestRequest("api/v3/task", Method.Post);
            req.AddHeader("Authorization", "Bearer " + token);
            req.AddJsonBody(body);
            return _client.Execute<RootTaskMPResponse>(req);
        }
        public RestResponse<RootTaskMPResponse> OpenTaskId(int id, string token)
        {
            var req = new RestRequest($"api/v3/task/{id}", Method.Get);
            req.AddHeader("Authorization", "Bearer " + token);
            return _client.Execute<RootTaskMPResponse>(req);
        }
    }
}
