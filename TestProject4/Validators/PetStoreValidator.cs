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
            //Assert.IsTrue(requst.Id == client.Id, $"Id не совпадает,в ответе {requst.Id} вместо {client.Id}");
            //Assert.IsTrue(requst.Email == client.Email, $"Email не совпадает,в ответе {requst.Email} вместо {client.Email}");
            //Assert.IsTrue(requst.Password == client.Password, $"Password не совпадает,в ответе {requst.Password} вместо {client.Password}");
            //Assert.IsTrue(requst.FirstName == client.FirstName, $"FirstName не совпадает,в ответе {requst.FirstName} вместо {client.FirstName}");
            //Assert.IsTrue(requst.LastName == client.LastName, $"LastName не совпадает,в ответе {requst.LastName} вместо {client.LastName}");
            //Assert.IsTrue(requst.Username == client.Username, $"Username не совпадает,в ответе {requst.Username} вместо {client.Username}");
            //Assert.IsTrue(requst.Phone == client.Phone, $"Phone не совпадает,в ответе {requst.Phone} вместо {client.Phone}");
            //Assert.IsTrue(requst.UserStatus == client.UserStatus, $"UserStatus не совпадает,в ответе {requst.UserStatus} вместо {client.UserStatus}");

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
            //Assert.IsTrue(response.Code == code, $"Code не совпадает,в ответе {response.Code} вместо {code}");
            //Assert.IsTrue(response.Type == type, $"Type не совпадает,в ответе {response.Type} вместо {type}");
            //Assert.IsTrue(response.Message == message, $"Message не совпадает,в ответе {response.Message} вместо {message}");
            response.Should().BeEquivalentTo<AnswerResponse>(error);
        }
    }
}
