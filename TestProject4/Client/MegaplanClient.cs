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
        /// <summary>
        /// Авторизация сотрудника
        /// </summary>
        /// <param name="body">Данные сотрудника для входа</param>
        public void AuthEmployee(AuthEmployeeRequest body)
        {
            var req = new RestRequest("api/v3/auth/access_token", Method.Post);
            req.AddJsonBody(body);
            _client.AddDefaultHeader("Authorization", "Bearer " + _client.Execute<AccessTokenResponse>(req).Data.AccessToken);
        }
        /// <summary>
        /// Создание задачи
        /// </summary>
        /// <param name="body">Параметры задачи</param>
        /// <returns></returns>
        public RestResponse<BasicTaskResponse> CreateTask(TaskCreateRequest body)
        {
            var req = new RestRequest("api/v3/task", Method.Post);
            //req.AddHeader("Authorization", "Bearer " + token);
            req.AddJsonBody(body);
            return _client.Execute<BasicTaskResponse>(req);
        }
        /// <summary>
        /// Открыть задачу
        /// </summary>
        /// <param name="id">Номер задачи</param>
        /// <returns></returns>
        public RestResponse<BasicTaskResponse> OpenTaskId(int id)
        {
            var req = new RestRequest($"api/v3/task/{id}", Method.Get);
            //req.AddHeader("Authorization", "Bearer " + token);
            return _client.Execute<BasicTaskResponse>(req);
        }
    }
}
