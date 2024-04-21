using AutotestAPI.Client;
using AutotestAPI.Entities.PlatziFakeStore.Requests;
using AutotestAPI.Framework;
using static AutotestAPI.Framework.EnumAssertion;

namespace AutotestAPI.Tests
{
    public class TestsPlatziFakeStore
    {
        /// <summary>
        /// Тестовое задание 1, сценарий первый 
        /// Удаление клиента
        /// </summary>
        [Test]
        public void TestDeleteUser()
        {
            var client = new PlatziFakeStoreClient("https://api.escuelajs.co");
            var createUserRequest = new CreateUserRequest
            {
                Avatar = GenerationData.GenerationUrl(13),
                Email = GenerationData.GenerationEmail(),
                Name = GenerationData.GenerationString(13),
                Password = GenerationData.GenerationString(13),
                Role = Role.admin.ToString(),
            };
            var resp = client.CreateUsers(createUserRequest);
            var respUserId = client.GetUsersId(resp.Data.Id);
            Validators.PlatziFakeStoreValidator.CheckParametrUser(resp.Data, respUserId.Data);
            client.DeleteUsersId(respUserId.Data.Id);
            var respDeleteId = client.GetUsersId(respUserId.Data.Id);
            Framework.AssertionHelper.ChecksStatus(respDeleteId, 400);
        }
        /// <summary>
        /// Тестовое задание 1, сценарий Второй 
        /// Создание, обновление и удаление категории
        /// </summary>
        [Test]
        public void DeleteCategories()
        {
            var client = new PlatziFakeStoreClient("https://api.escuelajs.co");
            var createCategoriesRequest = new CreateCategoriesRequest
            {
                Image = GenerationData.GenerationUrl(13),
                Name = GenerationData.GenerationString(13),
            };
            var putCategoriesRequest = new CreateCategoriesRequest
            {
                Name = GenerationData.GenerationString(10)
            };

            var resp = client.CreateCategories(createCategoriesRequest);
            var respCategoriesId = client.GetCategoriesId(resp.Data.Id);
            Framework.AssertionHelper.ChecksStatus(respCategoriesId);
            var respPutCategory = client.PutCategoriesId(putCategoriesRequest, respCategoriesId.Data.Id);
            Framework.AssertionHelper.ChecksStatus(respPutCategory);
            var respPutCategoriesId = client.GetCategoriesId(respPutCategory.Data.Id);
            Validators.PlatziFakeStoreValidator.CheckCategorie(respPutCategory.Data, respPutCategoriesId.Data);
            var respDeleteCategorie = client.DeleteCategoriesId(respCategoriesId.Data.Id);
            Framework.AssertionHelper.ChecksStatus(respDeleteCategorie);
            var respDeleteCategoriesId = client.GetCategoriesId(respPutCategory.Data.Id);
            Framework.AssertionHelper.ChecksStatus(respDeleteCategoriesId, 400);

        }
        /// <summary>
        /// Тестовое задание 1, сценарий третий 
        /// Авторизация клиента
        /// </summary>
        [Test]
        public void LoginUser()
        {
            var client = new PlatziFakeStoreClient("https://api.escuelajs.co");
            var createUserRequest = new CreateUserRequest
            {
                Avatar = GenerationData.GenerationUrl(13),
                Email = GenerationData.GenerationEmail(),
                Name = GenerationData.GenerationString(13),
                Password = GenerationData.GenerationString(13),
                Role = GenerationData.GenerationRole(0),
            };

            var resp = client.CreateUsers(createUserRequest);
            var loginResp = client.LoginUser(new LoginUserRequest
            {
                Email = createUserRequest.Email,
                Password = createUserRequest.Password
            });

            var userResp = client.GetProfileUser(loginResp.Data.AccessToken);
            Framework.AssertionHelper.ChecksStatus(userResp);
            Validators.PlatziFakeStoreValidator.CheckParametrUser(resp.Data, userResp.Data);
        }
    }
}
