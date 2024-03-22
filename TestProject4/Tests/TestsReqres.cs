//start test
namespace TestProject4
{
    public class TestsReqres
    {
        //Вызов метода CreateClient
        [Test]
        public void TestCreatedClient()
        {
            var client = new ReqresClient("https://reqres.in");
            var createClientRequest = new CreateClientRequest
                {
                    Job = GenerationData.GenerationString(10),
                    Name = "dasgsag"
                };
            var resp = client.CreateClient(createClientRequest);
            if (resp.Data != null)
            {
                Console.WriteLine(resp.Data.Id);
                CheckStatus.ChecksStatus(resp, 201);
            }else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода GetResourcePage
        [Test]
        public void TestResourceList()
        {

            var client = new ReqresClient("https://reqres.in");
            var resp = client.GetResourcePage(2,3);
            if (resp.Data != null)
            {
                Console.WriteLine(resp.Data.Page);
                CheckStatus.ChecksStatus(resp);
            } else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода GetClientPage
        [Test]
        public void TestClientPage()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.GetClientPage(2);
            if (resp.Data != null)
            {
                var georgeEdwards = resp.Data.Data.First(p => p.FirstName == "George" && p.LastName == "Edwards");
                Console.WriteLine(georgeEdwards.Email);
                CheckStatus.ChecksStatus(resp);
            }else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода GetClientId
        [Test]
        public void TestGetClientId()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.GetClientId(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода PutUpdateClient
        [Test]
        public void TestPutUpdateClient()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.PutUpdateClient(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода PutchUpdateClient
        [Test]
        public void TestPutchUpdateClient()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.PutchUpdateClient(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода DeleteClient
        [Test]
        public void TestDeleteClient()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.DeleteClient(2);
            if (resp != null)
            {
                CheckStatus.ChecksStatus(resp, 204);
            }
            else { Assert.Fail("Ответ не пустой"); }
        }
        //Вызов метода GetResourcePage
        [Test]
        public void TestGetResourcePage()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.GetResourcePage(1);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода PutUpdateResourceList
        [Test]
        public void TestPutUpdateResourceList()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.PutUpdateResourceList(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода PutchUpdateResourceList
        [Test]
        public void TestPutchUpdateResourceList()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.PutchUpdateResourceList(2);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp);
            }
            else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода PutchUpdateResourceList
        [Test]
        public void TestDeleteResourceList()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.DeleteResourceList(2);
            if (resp != null)
            {
                CheckStatus.ChecksStatus(resp, 204);
            }
            else { Assert.Fail("Ответ не пустой"); }
        }
        //Вызов метода CreateSessionClient
        [Test]
        public void TestCreateSessionClient()
        {
            var client = new ReqresClient("https://reqres.in");
            var createClientRequest = new LoginRequest
            {
                Name = GenerationData.GenerationString(10),
                Email = GenerationData.GenerationEmail(10),
                Password = GenerationData.GenerationString(10)
            };
            var resp = client.CreateSessionClient(createClientRequest);
            if (resp.Data != null)
            {
                Console.WriteLine(GenerationData.GenerationString(10));
                Console.WriteLine(GenerationData.GenerationSpecialCharacters(10));
                Console.WriteLine(GenerationData.GenerationEmail(17));
                Console.WriteLine(GenerationData.GenerationInt(9));
                Console.WriteLine(GenerationData.GenerationLong(18));
                CheckStatus.ChecksStatus(resp, 400);
            }
            else
            {
                Assert.Fail("Пустой ответ");
            }
        }
        //Вызов метода CreateSessionClient
        [Test]
        public void TestRegisterClient()
        {
            var client = new ReqresClient("https://reqres.in");
            var createClientRequest = new RegisterRequest
            {
                Name = GenerationData.GenerationString(10),
                Email = GenerationData.GenerationString(10),
                Password = GenerationData.GenerationString(10)
            };
            var resp = client.RegisterClient(createClientRequest);
            if (resp.Data != null)
            {
                CheckStatus.ChecksStatus(resp, 400);
            }
            else { Assert.Fail("Пустой ответ"); }
        }
        //Вызов метода LogoutClient
        [Test]
        public void TestLogoutClient()
        {
            var client = new ReqresClient("https://reqres.in");
            var resp = client.LogoutClient();
            if (resp != null)
            {
                CheckStatus.ChecksStatus(resp, 200);
            }
            else { Assert.Fail("Ответ не пустой"); }
        }

    }
}
