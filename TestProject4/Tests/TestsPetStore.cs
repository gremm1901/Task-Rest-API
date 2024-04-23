using AutotestAPI.Client;
using AutotestAPI.Framework;
using AutotestAPI.Entities.PetStore.Request;
using AutotestAPI.Entities.PetStore.Responses;
using AssertionHelper = AutotestAPI.Framework.AssertionHelper;
using EnumHelper = AutotestAPI.Framework.EnumHelper;
using static AutotestAPI.Enums.DomenEnum;
using static AutotestAPI.Enums.StatusEnum;
using AutotestAPI.Validators;

namespace AutotestAPI.Tests
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
            //arrange
            var client = new PetStoreClient(EnumHelper.GetDescription(PetStore));
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
            ///act
            client.CreateWithListUser(createUserRequest);
            client.GetUser(createUserRequest[0].Username);
            client.DeleteUser(createUserRequest[0].Username);
            var respFinel = client.GetUser(createUserRequest[0].Username);
            ///assert
            AssertionHelper.ChecksStatus(respFinel, 404);
        }
        /// <summary>
        /// Тестовое задание 3
        /// Создание и проверка клиента
        /// </summary>
        [Test]
        public void TestGetUserPetStore()
        {
            var client = new PetStoreClient(EnumHelper.GetDescription(PetStore));
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
            var getResp = client.GetUser(createUserRequest.Username);
            PetStoreValidator.CheckParametrUser(createUserRequest, getResp.Data);
            AssertionHelper.ChecksStatus(getResp, 200);
        }
        /// <summary>
        /// Тестовое задание 4
        /// Нахождение произвольного петомца со статусом available
        /// </summary>
        [Test]
        public void TestGetPetParametr()
        {
            var client = new PetStoreClient(EnumHelper.GetDescription(PetStore));
            var resp = client.GetPetFindByStatus(EnumHelper.GetDescription(Available));
            AssertionHelper.ChecksStatus(resp);
            var idPet = resp.Data[GenerationData.GenerationInt(1)].Id;
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
            var client = new PetStoreClient(EnumHelper.GetDescription(PetStore));
            var resp = client.GetPetId(GenerationData.GenerationLong(18));
            AssertionHelper.ChecksStatus(resp, 404);
            PetStoreValidator.CheckErrorMesseg(resp.Data, new AnswerResponse
            {
                Code = 1,
                Type = "error",
                Message = "Pet not found"
            });
        }
    }
}
