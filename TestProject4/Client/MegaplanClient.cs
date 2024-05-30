﻿using Aspose.Pdf;
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
            req.AddJsonBody(body);
            return _client.Execute<BasicTaskResponse>(req);
        }
        /// <summary>
        /// Открыть задачу
        /// </summary>
        /// <param name="id">Номер задачи</param>
        /// <returns></returns>
        public RestResponse<BasicTaskResponse> OpenTaskId(string id)
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
        public RestResponse<BasicProjectResponse> OpenProjectId(string id)
        {
            var req = new RestRequest($"api/v3/project/{id}", Method.Get);
            return _client.Execute<BasicProjectResponse>(req);
        }
        /// <summary>
        /// Загрузить файл
        /// </summary>
        /// <returns></returns>
        public RestResponse<FileBaseResponse> AddFile(Document doc)
        {
            var req = new RestRequest($"api/file", Method.Post);
            Console.WriteLine(doc);
            req.AddFile("files[]", File.ReadAllBytes(@"./document.pdf"), Path.GetFileName(@"./document.pdf"), "multipart/form-data");
            return _client.Execute<FileBaseResponse>(req);
        }
        /// <summary>
        /// Написать комментарий в любую сущность
        /// </summary>
        /// <param name="id">Номер сущности</param>
        /// <param name="entity">Название сущности</param>
        /// <param name="body">Тело комментария</param>
        /// <returns></returns>
        public RestResponse<BasicComentResponse> AddComment(string id, string entity, CreateCommentRequest body)
        {
            var req = new RestRequest($"api/v3/{entity}/{id}/comments", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<BasicComentResponse>(req);
        }
        /// <summary>
        /// Массовое удаление задач
        /// </summary>
        /// <param name="body">Список задач на удаление</param>
        public RestResponse<MassDeleteResponse> MassDelete(MassDeleteRequest body)
        {
            var req = new RestRequest($"api/v3/massActionDelete", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<MassDeleteResponse>(req);
        }
        /// <summary>
        /// Изменить проект
        /// </summary>
        /// <param name="body">Что изменить</param>
        /// <param name="id">Номер проекта</param>
        /// <returns></returns>
        public RestResponse<BasicProjectResponse> UpdateProject(ProjectCreateRequest body, string id)
        {
            var req = new RestRequest($"api/v3/project/{id}", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<BasicProjectResponse>(req);
        }
        /// <summary>
        /// Изменить задачу
        /// </summary>
        /// <param name="body">Что изменить</param>
        /// <param name="id">Номер задачи</param>
        /// <returns></returns>
        public RestResponse<BasicTaskResponse> UpdateTask(TaskCreateRequest body, string id)
        {
            var req = new RestRequest($"api/v3/task/{id}", Method.Post);
            req.AddJsonBody(body);
            return _client.Execute<BasicTaskResponse>(req);
        }
    }
}
