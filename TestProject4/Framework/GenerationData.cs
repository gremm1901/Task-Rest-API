namespace AutotestAPI
{
    public static class GenerationData
    {
        /// <summary>
        /// Генерация строки без спец символов
        /// </summary>
        /// <param name="length">Длина строки</param>
        /// <returns></returns>
        public static string GenerationString(int length)
        {
            Random random = new Random();
            string str = "";
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnm";
            //return new string(Enumerable.Repeat(chars, length)
            //    .Select(s => s[random.Next(s.Length)]).ToArray()); нашел в инете и не понял как оно работает поэтому сохранил 

            for (int i = 0; i < length; i++)
            {
                str = str + chars[random.Next(chars.Length)];
            }
            return str;
        }
        /// <summary>
        /// Генерация строки из спец символов
        /// </summary>
        /// <param name="length">длина строки</param>
        /// <returns></returns>
        public static string GenerationSpecialCharacters(int length)
        {
            Random random = new Random();
            string str = "";
            const string chars = "!@#$%^&*()_+=|/?.,m";
            for (int i = 0; i < length; i++)
            {
                str = str + chars[random.Next(chars.Length)];
            }
            return str;
        }
        /// <summary>
        /// Генерация почты
        /// </summary>
        /// <param name="length">примерная длина строки</param>
        /// <returns></returns>
        public static string GenerationEmail(int length = 21)
        {
            Random random = new Random();
            string str = "";
            string strDomen = "";
            const string chars = "qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < (length-3)/2; i++)
            {
                str = str + chars[random.Next(chars.Length)];
            }
            for (int i = 0; i < (length - 3) / 2; i++)
            {
                strDomen = strDomen + chars[random.Next(chars.Length)];
            }
            return str + "@" + strDomen+".ru";
        }
        /// <summary>
        /// Генерация случайного положительного числа, длиною 9 символов
        /// </summary>
        /// <param name="length">длинна числа</param>
        /// <returns></returns>
        public static int GenerationInt(int length)
        {
            Random random = new Random();
            string str = "";
            const string chars = "1234567890";
            for (int i = 0; i < length; i++)
            {
                str = str + chars[random.Next(chars.Length)];
            }
            return Convert.ToInt32(str);
        }
        /// <summary>
        /// Генерация случайного положительного числа, длиною 18 символов
        /// </summary>
        /// <param name="length">длинна числа</param>
        /// <returns></returns>
        public static long GenerationLong(int length)
        {
            Random random = new Random();
            string str = "";
            const string chars = "1234567890";
            for (int i = 0; i < length; i++) 
            {
                str = str + chars[random.Next(chars.Length)];
            }
            return Convert.ToInt64(str);
        }
    }
}
