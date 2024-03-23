namespace AutotestAPI
{
    public class TestsPetStore
    {
        [Test]
        public void TestGetUserPetStore()
        {
            string usernameOne = GenerationData.GenerationString(6);
            string usernameTwo = GenerationData.GenerationString(7);
            var client = new PetStoreClient("https://petstore.swagger.io");
            var createUserRequest = new List<CreateUserRequest>{
                new CreateUserRequest {
                Id = GenerationData.GenerationInt(5),
                Username = usernameOne,
                FirstName = "test",
                LastName = "test",
                Email = "test",
                Password = "test",
                Phone = "test",
                UserStatus = 0},
                new CreateUserRequest {
                Id = GenerationData.GenerationInt(4),
                Username = usernameTwo,
                FirstName = "test",
                LastName = "test",
                Email = "test",
                Password = "test",
                Phone = "test",
                UserStatus = 0}
            };
            var resp1 = client.CreateWithListUser(createUserRequest);
            var resp = client.GetUserPetStore(usernameOne);
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
