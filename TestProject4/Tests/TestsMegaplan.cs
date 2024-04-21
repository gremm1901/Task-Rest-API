using AutotestAPI.Client;
using AutotestAPI.Entities.Megaplan.Requests;
using AutotestAPI.Framework;
using Newtonsoft.Json;

namespace AutotestAPI.Tests
{
    public class TestsMegaplan
    {
        [Test]
        public void TestGetPetByAbsentId()
        {
            var createUserRequest = new AuthEmployeeRequest
            {
                Username = "grisha.manuk1",
                Password = "grisha.manuk1",
                GrantType = "password"
            };
            var createTaskRequest = new TaskCreateRequest
            {
                Name = GenerationData.GenerationString(10),
                Responsible = new ResponsibleRequest
                {
                    Id = "1000157",
                    ContentType = "Employee",
                },
                IsTemplate = false,
                IsUrgent = false
            };

            var client = new MegaplanClient("https://ra.megaplan.ru");
            var resp = client.AuthEmployee(createUserRequest);
            Framework.AssertionHelper.ChecksStatus(resp);

            var respCreateTask = client.CreateTask(createTaskRequest, resp.Data.AccessToken);
            Framework.AssertionHelper.ChecksStatus(respCreateTask);

            var OpenTask = client.OpenTaskId(Convert.ToInt32(respCreateTask.Data.Data.Id), resp.Data.AccessToken);
            Framework.AssertionHelper.ChecksStatus(OpenTask);
        }
    }
}
