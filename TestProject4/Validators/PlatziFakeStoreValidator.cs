using AutotestAPI.Entities.PlatziFakeStore.Responses;
using FluentAssertions;

namespace AutotestAPI.Validators
{
    public class PlatziFakeStoreValidator
    {
        /// <summary>
        /// Проверяет данные клиента в PFS
        /// </summary>
        /// <param name="requst">Изначальные данные клиента</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckParametrUser(UserResponse response, UserResponse client)
        {
            response.Should().BeEquivalentTo(client);
        }
        /// <summary>
        /// Проверяет данные категории
        /// </summary>
        /// <param name="requst">Изначальные данные категории</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckCategorie(CategoriesResponse response, CategoriesResponse client)
        {
            response.Should().BeEquivalentTo(client);
        }
    }
}
