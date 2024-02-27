//start test
namespace TestProject4
{
    public class TestReqres
    {
        //3 задание
        [Test]
        public void TestCreatedClient()
        {
            var request = new ReqresClient("https://reqres.in");
            var createClient = new CreateClient();
            var resp = request.CreateClient(createClient.CreateClients("asd","fwewef"));

            var client = JsonConvert.DeserializeObject<CreatedClient>(resp.Content);

            Console.WriteLine(client.Id);
            request.checkStatus(resp, 201);
        }
        //2 задание
        [Test]
        public void TestResourceList()
        {

            var request = new ReqresResurceList("https://reqres.in");
            var resp = request.GetResourceList(2,3);

            var resurceList = JsonConvert.DeserializeObject<ResourceList>(resp.Content);

            Console.WriteLine(resurceList.Page);
            request.checkStatus(resp);
        }
        [Test]
        public void TestClientPage()
        {
            var request = new ReqresClient("https://reqres.in");
            var resp = request.GetClientPage(2);

            var People = JsonConvert.DeserializeObject<BasicInformation>(resp.Content);

            var georgeEdwards = People.Data.First(p => p.FirstName == "George" && p.LastName == "Edwards");
            Console.WriteLine(georgeEdwards.Email);
            request.checkStatus(resp);
                
        }

    }
}
