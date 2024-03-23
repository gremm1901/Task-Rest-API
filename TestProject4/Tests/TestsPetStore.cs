using System.Numerics;

namespace AutotestAPI
{
    public class TestsPetStore
    {
        [Test]
        public void TestGetUserPetStore()
        {
            string usernameOne = GenerationData.GenerationString(6);
            string usernameTwo = GenerationData.GenerationString(7);
            Console.WriteLine(usernameOne);
            Console.WriteLine(usernameTwo);
            var client = new PetStoreClient("https://petstore.swagger.io");
            var createUserRequest = new List<CreateUserRequest>{
                new CreateUserRequest {
                Id = GenerationData.GenerationInt(5),
                Username = GenerationData.GenerationString(4),
                FirstName = "test",
                LastName = "test",
                Email = "test",
                Password = "test",
                Phone = "test",
                UserStatus = 0},
                new CreateUserRequest {
                Id = GenerationData.GenerationInt(4),
                Username = GenerationData.GenerationString(4),
                FirstName = "test",
                LastName = "test",
                Email = "test",
                Password = "test",
                Phone = "test",
                UserStatus = 0}
            };
            var resp1 = client.CreateWithListUser(createUserRequest);
            Console.WriteLine(resp1.Data.Code);
            var resp = client.GetUserPetStore(usernameOne);
            Console.WriteLine(resp.Data.Code);
            Console.WriteLine(resp.Data.Code);
            Console.WriteLine(createUserRequest[0]);
            Console.WriteLine((int)resp.StatusCode == 200);
            if (resp.Data != null && (int)resp.StatusCode == 200)
            {
                client.DeleteUserPetStore(usernameOne);
                var respFinel = client.GetUserPetStore(usernameOne);
                CheckStatus.ChecksStatus(respFinel, 404);
            }
            else { Console.WriteLine(resp.Data.Message); Assert.Fail("Клиент не создался"); }
        }
    }
}
