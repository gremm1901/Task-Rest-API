namespace AutotestAPI
{
    public static class GenerationData
    {
        static readonly string charsNumbers = "1234567890";
        static readonly string charsSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnm";
        static readonly string charsSpecial = "!@#$%^&*()_+=|/?.,m";
        /// <summary>
        /// Генерация строки без спец символов
        /// </summary>
        /// <param name="length">Длина строки</param>
        /// <returns></returns>
        public static string GenerationString(int length)
        {
            string str = "";
            Random random = new Random();
            //return new string(Enumerable.Repeat(chars, length)
            //    .Select(s => s[random.Next(s.Length)]).ToArray()); нашел в инете и не понял как оно работает поэтому сохранил 

            for (int i = 0; i < length; i++)
            {
                str = str + charsSymbols[random.Next(charsSymbols.Length)];
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
            for (int i = 0; i < length; i++)
            {
                str = str + charsSpecial[random.Next(charsSpecial.Length)];
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
            for (int i = 0; i < (length-3)/2; i++)
            {
                str = str + charsSymbols[random.Next(charsSymbols.Length)];
            }
            for (int i = 0; i < (length - 3) / 2; i++)
            {
                strDomen = strDomen + charsSymbols[random.Next(charsSymbols.Length)];
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
            for (int i = 0; i < length; i++)
            {
                str = str + charsNumbers[random.Next(charsNumbers.Length)];
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
            for (int i = 0; i < length; i++) 
            {
                str = str + charsNumbers[random.Next(charsNumbers.Length)];
            }
            return Convert.ToInt64(str);
        }
    }
}
