using AutotestAPI.Entities.Megaplan.Requests;
using AutotestAPI.Entities.Megaplan.Responses;
using System.IO;

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
            return _client.Execute<BasicTaskResponse>(req);
        }
        /// <summary>
        /// Создание проекта
        /// </summary>
        /// <param name="body">Параметры задачи</param>
        /// <returns></returns>
        public RestResponse<BasicProjectResponse> CreateProject(ProjectCreateRequest body)
        {
            var req = new RestRequest("api/v3/project", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<BasicProjectResponse>(req);
        }
        /// <summary>
        /// Открыть проект
        /// </summary>
        /// <param name="id">Номер проекта</param>
        /// <returns></returns>
        public RestResponse<BasicProjectResponse> OpenProjectId(int id)
        {
            var req = new RestRequest($"api/v3/project/{id}", Method.Get);
            return _client.Execute<BasicProjectResponse>(req);
        }
        /// <summary>
        /// Загрузить файл
        /// </summary>
        /// <param name="id">Номер проекта</param>
        /// <returns></returns>
        public RestResponse<FileResponse> AddFile()
        {
            var req = new RestRequest($"api/file", Method.Post);
            req.AddFile("receipt[receipt_file]", File.ReadAllBytes(@"C:\Users\grish\Downloads\123.jpeg"), Path.GetFileName(@"C:\Users\grish\Downloads\123.jpeg"), "application/octet-stream");
            return _client.Execute<FileResponse>(req);
        }
    }
}
