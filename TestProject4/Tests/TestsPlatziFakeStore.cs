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
            var createUserRequest = new CreateUserPFSRequest
            {
                Avatar = GenerationData.GenerationUrl(13),
                Email = GenerationData.GenerationEmail(),
                Name = GenerationData.GenerationString(13),
                Password = GenerationData.GenerationString(13),
                Role = GenerationData.GenerationRole(0),
            };
            var resp = client.CreateUsersPFS(createUserRequest);
            var respUserId = client.GetUsersIdPFS(resp.Data.Id);
            AssertionHelper.CheckParametrUserPFS(resp.Data, respUserId.Data);
            client.DeleteUsersIdPFS(respUserId.Data.Id);
            var respDeleteId = client.GetUsersIdPFS(respUserId.Data.Id);
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
            var createCategoriesRequest = new CreateCategoriesPFSRequest
            {
                Image = GenerationData.GenerationUrl(13),
                Name = GenerationData.GenerationString(13),
            };
            var putCategoriesRequest = new CreateCategoriesPFSRequest
            {
                Name = GenerationData.GenerationString(10)
            };

            var resp = client.CreateCategoriesPFS(createCategoriesRequest);
            var respCategoriesId = client.GetCategoriesIdPFS(resp.Data.Id);
            AssertionHelper.ChecksStatus(respCategoriesId);
            var respPutCategory = client.PutCategoriesIdPFS(putCategoriesRequest, respCategoriesId.Data.Id);
            AssertionHelper.ChecksStatus(respPutCategory);
            var respPutCategoriesId = client.GetCategoriesIdPFS(respPutCategory.Data.Id);
            AssertionHelper.CheckCategoriePFS(respPutCategory.Data, respPutCategoriesId.Data);
            var respDeleteCategorie = client.DeleteCategoriesIdPFS(respCategoriesId.Data.Id);
            AssertionHelper.ChecksStatus(respDeleteCategorie);
            var respDeleteCategoriesId = client.GetCategoriesIdPFS(respPutCategory.Data.Id);
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
            var createUserRequest = new CreateUserPFSRequest
            {
                Avatar = GenerationData.GenerationUrl(13),
                Email = GenerationData.GenerationEmail(),
                Name = GenerationData.GenerationString(13),
                Password = GenerationData.GenerationString(13),
                Role = GenerationData.GenerationRole(0),
            };
            var resp = client.CreateUsersPFS(createUserRequest);
            var loginResp = client.LoginUserPFS(new LoginUserPFSRequest
            {
                Email = createUserRequest.Email,
                Password = createUserRequest.Password
            });
            var userResp = client.GetProfileUserPFS(loginResp.Data.AccessToken);
            AssertionHelper.ChecksStatus(userResp);
            AssertionHelper.CheckParametrUserPFS(resp.Data, userResp.Data);
        }
    }
}
