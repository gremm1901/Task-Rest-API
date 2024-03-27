namespace AutotestAPI
{
    /// <summary>
    /// Класс в котором собраны вспомогательные функции
    /// </summary>
    public static class AssertionHelper
    {

        /// <summary>
        /// Возвращает булевое значение при проверки статуса
        /// </summary>
        /// <param name="requst">Реквест</param>
        /// <param name="status">Статуст который мы ожидаем</param>
        /// <returns></returns>
        public static bool CheckStatusBool(RestResponse requst, int status = 200)
        {
            return (int)requst.StatusCode == status;
        }
        /// <summary>
        /// Проверяет статус
        /// </summary>
        /// <param name="requst">Реквест</param>
        /// <param name="status">Статуст который мы ожидаем</param>
        public static void ChecksStatus(RestResponse requst, int status = 200)
        {

            Assert.IsTrue(CheckStatusBool(requst, status), $"Статус код {(int)requst.StatusCode} не соответствует {status}");
        }
        /// <summary>
        /// Проверяет данные клиента в PFS
        /// </summary>
        /// <param name="requst">Изначальные данные клиента</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckParametrUserPFS(CreateUserResponse requst, CreateUserResponse client)
        {
            Assert.IsTrue(requst.Id == client.Id, $"Id не совпадает,в ответе {requst.Id} вместо {client.Id}");
            Assert.IsTrue(requst.Email == client.Email, $"Email не совпадает,в ответе {requst.Email} вместо {client.Email}");
            Assert.IsTrue(requst.Password == client.Password, $"Password не совпадает,в ответе {requst.Password} вместо {client.Password}");
            Assert.IsTrue(requst.Name == client.Name, $"Name не совпадает,в ответе {requst.Name} вместо {client.Name}");
            Assert.IsTrue(requst.Role == client.Role, $"Role не совпадает,в ответе {requst.Role} вместо {client.Role}");
            Assert.IsTrue(requst.Avatar == client.Avatar, $"Avatar не совпадает,в ответе {requst.Avatar} вместо {client.Avatar}");
            Assert.IsTrue(requst.CreationAt == client.CreationAt, $"CreationAt не совпадает,в ответе {requst.CreationAt} вместо {client.CreationAt}");
            Assert.IsTrue(requst.UpdatedAt == client.UpdatedAt, $"UpdatedAt не совпадает,в ответе {requst.UpdatedAt} вместо {client.UpdatedAt}");
        }
        /// <summary>
        /// Проверяет данные клиента в PS
        /// </summary>
        /// <param name="requst">Изначальные данные клиента</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckParametrUserPS(CreateUserPSRequest requst, UserPSResponse client)
        {
            Assert.IsTrue(requst.Id == client.Id, $"Id не совпадает,в ответе {requst.Id} вместо {client.Id}");
            Assert.IsTrue(requst.Email == client.Email, $"Email не совпадает,в ответе {requst.Email} вместо {client.Email}");
            Assert.IsTrue(requst.Password == client.Password, $"Password не совпадает,в ответе {requst.Password} вместо {client.Password}");
            Assert.IsTrue(requst.FirstName == client.FirstName, $"FirstName не совпадает,в ответе {requst.FirstName} вместо {client.FirstName}");
            Assert.IsTrue(requst.LastName == client.LastName, $"LastName не совпадает,в ответе {requst.LastName} вместо {client.LastName}");
            Assert.IsTrue(requst.Username == client.Username, $"Username не совпадает,в ответе {requst.Username} вместо {client.Username}");
            Assert.IsTrue(requst.Phone == client.Phone, $"Phone не совпадает,в ответе {requst.Phone} вместо {client.Phone}");
            Assert.IsTrue(requst.UserStatus == client.UserStatus, $"UserStatus не совпадает,в ответе {requst.UserStatus} вместо {client.UserStatus}");
        }

        /// <summary>
        /// Проверить текст ошибки
        /// </summary>
        /// <param name="requst">Ответ с ошибкой</param>
        /// <param name="code">Ожидаемые данные из поля code</param>
        /// <param name="type">Ожидаемые данные из поля type</param>
        /// <param name="message">Ожидаемые данные из поля message</param>
        public static void CheckErrorMesseg(AnswerPSResponse requst, int code, string type, string message)
        {
            Assert.IsTrue(requst.Code == code, $"Code не совпадает,в ответе {requst.Code} вместо {code}");
            Assert.IsTrue(requst.Type == type, $"Type не совпадает,в ответе {requst.Type} вместо {type}");
            Assert.IsTrue(requst.Message == message, $"Message не совпадает,в ответе {requst.Message} вместо {message}");
        }
        /// <summary>
        /// Проверяет данные категории
        /// </summary>
        /// <param name="requst">Изначальные данные категории</param>
        /// <param name="client">С чем сравнивать</param>
        public static void CheckCategoriePFS(CategoriesPFSResponse requst, CategoriesPFSResponse client)
        {
            Assert.IsTrue(requst.Name == client.Name, $"Name не совпадает,в ответе {requst.Name} вместо {client.Name}");
            Assert.IsTrue(requst.Id == client.Id, $"Id не совпадает,в ответе {requst.Id} вместо {client.Id}");
            Assert.IsTrue(requst.Image == client.Image, $"Image не совпадает,в ответе {requst.Image} вместо {client.Image}");
            Assert.IsTrue(requst.CreationAt == client.CreationAt, $"CreationAt не совпадает,в ответе {requst.CreationAt} вместо {client.CreationAt}");
            Assert.IsTrue(requst.UpdatedAt == client.UpdatedAt, $"UpdatedAt не совпадает,в ответе {requst.UpdatedAt} вместо {client.UpdatedAt}");
        }
    }
}