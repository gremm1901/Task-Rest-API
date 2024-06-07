using AutotestAPI.Client;
using AutotestAPI.Entities.reqres.Requests;
using AutotestAPI.Framework;
using AssertionHelper = AutotestAPI.Helpers.AssertionHelper;
using EnumHelper = AutotestAPI.Helpers.EnumHelper;
using static AutotestAPI.Enums.DomenEnum;

namespace AutotestAPI.Tests
{
    public class TestsReqres
    {
        //Вызов метода CreateClient
        [Test]
        public void TestCreatedClient()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var createClientRequest = new CreateClientRequest
            {
                Job = GenerationData.GenerationString(10),
                Name = "dasgsag"
            };
            var resp = client.CreateClient(createClientRequest);
            AssertionHelper.ChecksStatus(resp, 201);
        }
        //Вызов метода GetResourcePage
        [Test]
        public void TestResourceList()
        {

            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.GetResourcePage(2, 3);
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода GetClientPage
        [Test]
        public void TestClientPage()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.GetClientPage(2);
            var georgeEdwards = resp.Data.Data.First(p => p.FirstName == "George" && p.LastName == "Edwards");
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода GetClientId
        [Test]
        public void TestGetClientId()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.GetClientId(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода PutUpdateClient
        [Test]
        public void TestPutUpdateClient()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.PutUpdateClient(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода PutchUpdateClient
        [Test]
        public void TestPutchUpdateClient()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.PutchUpdateClient(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода DeleteClient
        [Test]
        public void TestDeleteClient()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.DeleteClient(2);
            AssertionHelper.ChecksStatus(resp, 204);
        }
        //Вызов метода GetResourcePage
        [Test]
        public void TestGetResourcePage()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.GetResourcePage(1);
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода PutUpdateResourceList
        [Test]
        public void TestPutUpdateResourceList()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.PutUpdateResourceList(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода PutchUpdateResourceList
        [Test]
        public void TestPutchUpdateResourceList()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.PutchUpdateResourceList(2);
            AssertionHelper.ChecksStatus(resp);
        }
        //Вызов метода PutchUpdateResourceList
        [Test]
        public void TestDeleteResourceList()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.DeleteResourceList(2);
            AssertionHelper.ChecksStatus(resp, 204);
        }
        //Вызов метода CreateSessionClient
        [Test]
        public void TestCreateSessionClient()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var createClientRequest = new LoginRequest
            {
                Name = GenerationData.GenerationString(10),
                Email = GenerationData.GenerationEmail(10),
                Password = GenerationData.GenerationString(10)
            };
            var resp = client.CreateSessionClient(createClientRequest);
            AssertionHelper.ChecksStatus(resp, 400);
        }
        //Вызов метода CreateSessionClient
        [Test]
        public void TestRegisterClient()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var createClientRequest = new RegisterRequest
            {
                Name = GenerationData.GenerationString(10),
                Email = GenerationData.GenerationString(10),
                Password = GenerationData.GenerationString(10)
            };
            var resp = client.RegisterClient(createClientRequest);
            AssertionHelper.ChecksStatus(resp, 400);
        }
        //Вызов метода LogoutClient
        [Test]
        public void TestLogoutClient()
        {
            var client = new ReqresClient(EnumHelper.GetDescription(Reqres));
            var resp = client.LogoutClient();
            AssertionHelper.ChecksStatus(resp, 200);
        }

    }
}