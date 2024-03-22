namespace AutotestAPI
{
    static class CheckStatus
    {
        /// <summary>
        /// Возвращает булевое значение при проверки статуса
        /// </summary>
        /// <param name="requst">Реквест</param>
        /// <param name="status">Статуст который мы ожидаем</param>
        /// <returns></returns>
        public static bool CheckStatusBool(RestResponse requst, int status = 200)
        {
            bool check = (int)requst.StatusCode == status ? true : false;
            return check;
        }
        /// <summary>
        /// Заканчивает тест при проверке статуса
        /// </summary>
        /// <param name="requst">Реквест</param>
        /// <param name="status">Статуст который мы ожидаем</param>
        public static void ChecksStatus(RestResponse requst, int status = 200)
        {

            Assert.IsTrue((int)requst.StatusCode == status, $"Статус код не соответствует {status}");
        }
    }
}