using AutotestAPI.Entities.PetStore.Request;
using AutotestAPI.Entities.PetStore.Responses;
using FluentAssertions;

namespace AutotestAPI.Validators
{
    public class PetStoreValidator
    {
        /// <summary>
        /// Проверяет данные клиента в PS
        /// </summary>
        /// <param name="response">Изначальные данные клиента</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckParametrUser(CreateUserRequest response, UserResponse client)
        {
            response.Should().BeEquivalentTo(client);
        }
        /// <summary>
        /// Проверить текст ошибки
        /// </summary>
        /// <param name="response">Изначальные данные клиента</param>
        /// <param name="error">С чем сравнивать</param>
        public static void CheckErrorMesseg(AnswerResponse response, AnswerResponse error)
        {
            response.Should().BeEquivalentTo(error);
        }
    }
}
