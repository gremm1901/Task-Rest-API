using AutotestAPI.Client;
using AutotestAPI.Entities.Megaplan.Requests;
using AutotestAPI.Framework;

namespace AutotestAPI.Tests
{
    public class TestsMegaplan
    {
        [Test]
        public void TestGetPetByAbsentId()
        {
            //arrange
            var createUserRequest = new AuthEmployeeRequest
            {
                Username = "grisha.manuk1",
                Password = "grisha.manuk1",
                GrantType = "password"
            };
            var createTaskRequest = new TaskCreateRequest
            {
                ContentType = "Task",
                Name = GenerationData.GenerationString(10),
                Responsible = new ResponsibleRequest
                {
                    Id = "1000157",
                    ContentType = "Employee",
                },
                IsTemplate = false,
                IsUrgent = false,
                Category130CustomFieldTipDaNet = false
            };
            //act
            var client = new MegaplanClient("https://ra.megaplan.ru");
            var resp = client.AuthEmployee(createUserRequest);
            ///assert
            Framework.AssertionHelper.ChecksStatus(resp);
            //act
            var respCreateTask = client.CreateTask(createTaskRequest, resp.Data.AccessToken);
            ///assert
            Framework.AssertionHelper.ChecksStatus(respCreateTask);
            //act
            var OpenTask = client.OpenTaskId(Convert.ToInt32(respCreateTask.Data.Data.Id), resp.Data.AccessToken);
            ///assert
            Framework.AssertionHelper.ChecksStatus(OpenTask);
        }
    }
}
