using AutotestAPI.Entities.PetStore.Request;
using AutotestAPI.Entities.PetStore.Responses;
using AutotestAPI.Framework;
using FluentAssertions;

namespace AutotestAPI.Validators
{
    public class PetStoreValidator
    {
        /// <summary>
        /// Проверяет данные клиента в PS
        /// </summary>
        /// <param name="requst">Изначальные данные клиента</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckParametrUser(CreateUserRequest response, UserResponse client)
        {
            response.Should().BeEquivalentTo<UserResponse>(client);
        }
        /// <summary>
        /// Проверить текст ошибки
        /// </summary>
        /// <param name="requst">Ответ с ошибкой</param>
        /// <param name="code">Ожидаемые данные из поля code</param>
        /// <param name="type">Ожидаемые данные из поля type</param>
        /// <param name="message">Ожидаемые данные из поля message</param>
        public static void CheckErrorMesseg(AnswerResponse response, AnswerResponse error)
        {
            response.Should().BeEquivalentTo<AnswerResponse>(error);
        }
    }
}
