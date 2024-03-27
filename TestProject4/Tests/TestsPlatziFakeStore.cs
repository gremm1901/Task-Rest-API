namespace AutotestAPI
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
            var createUserRequest = new CreateUserPlatziFakeStoreRequest
            {
                Avatar = GenerationData.GenerationUrl(13),
                Email = GenerationData.GenerationEmail(),
                Name = GenerationData.GenerationString(13),
                Password = GenerationData.GenerationString(13),
                Role = GenerationData.GenerationRole(0),
            };
            var resp = client.CreateUsers(createUserRequest);
            var respUserId = client.GetUsersId(resp.Data.Id);
            AssertionHelper.CheckParametrUserPFS(resp.Data, respUserId.Data);
            client.DeleteUsersId(respUserId.Data.Id);
            var respDeleteId = client.GetUsersId(respUserId.Data.Id);
            AssertionHelper.ChecksStatus(respDeleteId, 400);
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
            AssertionHelper.ChecksStatus(respCategoriesId);
            var respPutCategory = client.PutCategoriesId(putCategoriesRequest, respCategoriesId.Data.Id);
            AssertionHelper.ChecksStatus(respPutCategory);
            var respPutCategoriesId = client.GetCategoriesId(respPutCategory.Data.Id);
            AssertionHelper.CheckCategorie(respPutCategory.Data, respPutCategoriesId.Data);
            var respDeleteCategorie = client.DeleteCategoriesId(respCategoriesId.Data.Id);
            AssertionHelper.ChecksStatus(respDeleteCategorie);
            var respDeleteCategoriesId = client.GetCategoriesId(respPutCategory.Data.Id);
            AssertionHelper.ChecksStatus(respDeleteCategoriesId, 400);

        }
        /// <summary>
        /// Тестовое задание 1, сценарий третий 
        /// Авторизация клиента
        /// </summary>
        [Test]
        public void LoginUser()
        {
            var client = new PlatziFakeStoreClient("https://api.escuelajs.co");
            var createUserRequest = new CreateUserPlatziFakeStoreRequest
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
            AssertionHelper.ChecksStatus(userResp);
            AssertionHelper.CheckParametrUserPFS(resp.Data, userResp.Data);
        }
    }
}
