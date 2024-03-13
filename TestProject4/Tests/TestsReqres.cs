//start test
namespace TestProject4
{
    public class TestsReqres
    {
        //3 задание
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
            Console.WriteLine(resp.Data.Id);
            CheckStatus.ChecksStatus(resp, 201);
        }
        //2 задание
        [Test]
        public void TestResourceList()
        {

            var client = new ReqresClient("https://reqres.in");
            var resp = client.GetResourcePage(2,3);
            Console.WriteLine(resp.Data.Page);
            CheckStatus.ChecksStatus(resp);
        }
        [Test]
        public void TestClientPage()
        {
            var request = new ReqresClient("https://reqres.in");
            var resp = request.GetClientPage(2);
            Console.WriteLine(resp.Data.Data[3].Id);
            Console.WriteLine(resp.Data.Data[3].Email);
            Console.WriteLine(resp.Data.Data[3].FirstName);
            Console.WriteLine(resp.Data.Data[3].LastName);
            Console.WriteLine(resp.Data.Data[3].Avatar);
            var georgeEdwards = resp.Data.Data.First(p => p.FirstName == "George" && p.LastName == "Edwards");
            Console.WriteLine(georgeEdwards.Email);
            CheckStatus.ChecksStatus(resp);      
        }

    }
}
