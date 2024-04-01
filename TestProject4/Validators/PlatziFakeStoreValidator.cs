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
            //Assert.IsTrue(requst.Id == client.Id, $"Id не совпадает,в ответе {requst.Id} вместо {client.Id}");
            //Assert.IsTrue(requst.Email == client.Email, $"Email не совпадает,в ответе {requst.Email} вместо {client.Email}");
            //Assert.IsTrue(requst.Password == client.Password, $"Password не совпадает,в ответе {requst.Password} вместо {client.Password}");
            //Assert.IsTrue(requst.Name == client.Name, $"Name не совпадает,в ответе {requst.Name} вместо {client.Name}");
            //Assert.IsTrue(requst.Role == client.Role, $"Role не совпадает,в ответе {requst.Role} вместо {client.Role}");
            //Assert.IsTrue(requst.Avatar == client.Avatar, $"Avatar не совпадает,в ответе {requst.Avatar} вместо {client.Avatar}");
            //Assert.IsTrue(requst.CreationAt == client.CreationAt, $"CreationAt не совпадает,в ответе {requst.CreationAt} вместо {client.CreationAt}");
            //Assert.IsTrue(requst.UpdatedAt == client.UpdatedAt, $"UpdatedAt не совпадает,в ответе {requst.UpdatedAt} вместо {client.UpdatedAt}");

            response.Should().BeEquivalentTo<UserResponse>(client);
        }
        /// <summary>
        /// Проверяет данные категории
        /// </summary>
        /// <param name="requst">Изначальные данные категории</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckCategorie(CategoriesResponse response, CategoriesResponse client)
        {
            //Assert.IsTrue(requst.Name == client.Name, $"Name не совпадает,в ответе {requst.Name} вместо {client.Name}");
            //Assert.IsTrue(requst.Id == client.Id, $"Id не совпадает,в ответе {requst.Id} вместо {client.Id}");
            //Assert.IsTrue(requst.Image == client.Image, $"Image не совпадает,в ответе {requst.Image} вместо {client.Image}");
            //Assert.IsTrue(requst.CreationAt == client.CreationAt, $"CreationAt не совпадает,в ответе {requst.CreationAt} вместо {client.CreationAt}");
            //Assert.IsTrue(requst.UpdatedAt == client.UpdatedAt, $"UpdatedAt не совпадает,в ответе {requst.UpdatedAt} вместо {client.UpdatedAt}");
            response.Should().BeEquivalentTo<CategoriesResponse>(client);
        }
    }
}
