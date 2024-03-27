using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace AutotestAPI
{
    public class TestsPetStore
    {
        /// <summary>
        /// Не тестовое задание
        /// Массовое создание клиента
        /// </summary>
        [Test]
        public void TestDeleteUserPetStore()
        {
            var client = new PetStoreClient("https://petstore.swagger.io");
            var createUserRequest = new List<CreateUserRequest>
            {
                new CreateUserRequest
                {
                Id = GenerationData.GenerationInt(4),
                Username = GenerationData.GenerationString(6),
                FirstName = GenerationData.GenerationString(6),
                LastName = GenerationData.GenerationString(6),
                Email = GenerationData.GenerationEmail(30),
                Password = GenerationData.GenerationString(15),
                Phone = GenerationData.GenerationMobilePhone(),
                UserStatus = 0
                },
                new CreateUserRequest
                {
                Id = GenerationData.GenerationInt(4),
                Username = GenerationData.GenerationString(6),
                FirstName = GenerationData.GenerationString(6),
                LastName = GenerationData.GenerationString(6),
                Email = GenerationData.GenerationEmail(30),
                Password = GenerationData.GenerationString(15),
                Phone = GenerationData.GenerationMobilePhone(),
                UserStatus = 0
                }
            };
            client.CreateWithListUser(createUserRequest);
            client.GetUserPetStore(createUserRequest[0].Username);
            client.DeleteUserPetStore(createUserRequest[0].Username);
            var respFinel = client.GetUserPetStore(createUserRequest[0].Username);
            AssertionHelper.ChecksStatus(respFinel, 404);
        }
        /// <summary>
        /// Тестовое задание 3
        /// Создание и проверка клиента
        /// </summary>
        [Test]
        public void TestGetUserPetStore()
        {
            var client = new PetStoreClient("https://petstore.swagger.io");
            var createUserRequest = new CreateUserRequest
            {
                Id = GenerationData.GenerationInt(4),
                Username = GenerationData.GenerationString(6),
                FirstName = GenerationData.GenerationString(6),
                LastName = GenerationData.GenerationString(6),
                Email = GenerationData.GenerationEmail(30),
                Password = GenerationData.GenerationString(15),
                Phone = GenerationData.GenerationMobilePhone(),
                UserStatus = 0
            };
            client.CreateUser(createUserRequest);
            var getResp = client.GetUserPetStore(createUserRequest.Username);
            AssertionHelper.CheckParametrUserPetStore(createUserRequest, getResp.Data);
            AssertionHelper.ChecksStatus(getResp, 200);
        }
        /// <summary>
        /// Тестовое задание 4
        /// Нахождение произвольного петомца со статусом available
        /// </summary>
        [Test]
        public void TestGetPetParametr()
        {
            var client = new PetStoreClient("https://petstore.swagger.io");
            var resp = client.GetPetFindByStatus("available");
            AssertionHelper.ChecksStatus(resp);
            var idPet = resp.Data[0].Id;
            var respPetId = client.GetPetId(idPet);
            AssertionHelper.ChecksStatus(respPetId);
            Assert.IsTrue(respPetId.Data.Id == idPet, $"Id не совпадает");
            Assert.IsTrue(respPetId.Data.Status == "available", $"Status не совпадает");
        }
        /// <summary>
        /// Тестовое задание 5
        /// Нахождение не существующего петомца и проверка ошибки
        /// </summary>
        [Test]
        public void TestGetPetByAbsentId()
        {
            var client = new PetStoreClient("https://petstore.swagger.io");
            var resp = client.GetPetId(GenerationData.GenerationLong(18));
            AssertionHelper.ChecksStatus(resp, 404);
            AssertionHelper.CheckErrorMesseg(resp.Data,1, "error", "Pet not found");
        }
    }
}
