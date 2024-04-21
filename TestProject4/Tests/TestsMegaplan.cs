using AutotestAPI.Client;
using AutotestAPI.Entities.Megaplan.Requests;
using AutotestAPI.Framework;
using AutotestAPI.Validators;
using AssertionHelper = AutotestAPI.Framework.AssertionHelper;

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
                Name = GenerationData.GenerationString(10),
                Responsible = new ResponsibleRequest
                {
                    Id = "1000157",
                    ContentType = "Employee",
                },
                IsTemplate = false,
                IsUrgent = false
            };
            //act
            var client = new MegaplanClient("https://ra.megaplan.ru");
            client.AuthEmployee(createUserRequest);
            var respCreateTask = client.CreateTask(createTaskRequest);
            var OpenTask = client.OpenTaskId(Convert.ToInt32(respCreateTask.Data.Data.Id));
            //Assert
            MegaplanValidator.CheckTask(respCreateTask.Data, OpenTask.Data);
            MegaplanValidator.CheckTaskName(respCreateTask.Data, OpenTask.Data);
            AssertionHelper.ChecksStatus(OpenTask);
        }
    }
}
